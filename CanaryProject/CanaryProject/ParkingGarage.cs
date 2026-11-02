using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanaryProject {
    public class ParkingGarage {
        private static ParkingGarage garage = null;

        //first index is floor # and second index is spot #.
        private List<List<Spot>> spots = null;

        //new List<List<Spot>>();
        List<Vehicle> unparked_vehicles = new List<Vehicle> { };
        public static ParkingGarage GetGarage() {
            if (garage is null) {
                garage = new ParkingGarage();
            }

            return garage;

        }

        private ParkingGarage() {

        }

        public void ParkVehicle(int spot_floor, int spot_index, int vehicle_index) {

            //edge case checks:
            //checking if vehicle_index contains a vehicle at the index.
            if (vehicle_index >= unparked_vehicles.Count || vehicle_index < 0) {
                Console.WriteLine("Parking vehicle failed due to out of bounds vehicle index");
                return;
            }
            if (spot_floor >= spots.Count || spot_floor < 0) {
                Console.WriteLine("Parking floor does not exist");
                return;
            }
            if (spot_index >= spots[spot_floor].Count || spot_index < 0) {
                Console.WriteLine("Spot index does not exist for the selected floor");
            }

            if (spots[spot_floor][spot_index].GetSize() < unparked_vehicles[vehicle_index].GetSize()) {
                Console.WriteLine("Parking vehicle failed due to Vehicle size is larger than spot size");
            }

            if (spots[spot_floor][spot_index].GetVehicle() != null) {
                Console.WriteLine("Parking spot already has a vehicle parked");
            }

            //Park vehicle in the spot
            spots[spot_floor][spot_index].SetVehicle(unparked_vehicles[vehicle_index]);
            spots[spot_floor][spot_index].GetVehicle().SetParkTime(DateTime.Now);

            unparked_vehicles.RemoveAt(vehicle_index);
        }

        public void UnparkVehicle(int spot_floor, int spot_index) {
            if (spot_floor >= spots.Count || spot_floor < 0) {
                Console.WriteLine("Parking floor does not exist");
                return;
            }
            if (spot_index >= spots[spot_floor].Count || spot_index < 0) {
                Console.WriteLine("Spot index does not exist for the selected floor");
            }
            if (spots[spot_floor][spot_index].GetVehicle() == null) {
                Console.WriteLine("Parking spot does not have a vehicle");
            }

            spots[spot_floor][spot_index].SetVehicle(null);

        }

        public void AddUnparkedVehicle(Vehicle vehicle) {
            unparked_vehicles.Add(vehicle);
        }

        public void AddSpot(int floor, int size) {
            spots[floor].Append(new Spot(size));
        }

        public void AddFloor() {
            spots.Add(new List<Spot>{});
        }

        public void Status() {
            for(int i = 0; i < spots.Count; i++) {
                Console.WriteLine("Floor " + i + ":");
                for(int j = 0; j < spots[i].Count; j++) {
                    Console.Write("Spot: " + j + " - Occupied By: " + spots[i][j].GetVehicle().GetName() + " - Duration Parked: " +
                       spots[i][j].GetVehicle().GetTime());
                }
                Console.WriteLine("");
            }
        }

        
    }
}
