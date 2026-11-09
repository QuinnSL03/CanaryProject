using System;
using System.Collections.Generic;

namespace CanaryProject {
    public class ParkingGarage {
        private static ParkingGarage garage = null;

        //first index is floor # and second index is spot #.
        private List<List<Spot>> spots = new List<List<Spot>>();

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
            if(unparked_vehicles.Count < 1)
            {
                Console.WriteLine("No avaliable vehicles to park");
                return;
            }
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
                return;
            }

            if (spots[spot_floor][spot_index].GetSize() < unparked_vehicles[vehicle_index].GetSize()) {
                Console.WriteLine("Parking vehicle failed due to Vehicle size is different than spot size");
                return;
            }

            if (spots[spot_floor][spot_index].GetVehicle() != null) {
                Console.WriteLine("Parking spot already has a vehicle parked");
                return;
            }

            //Park vehicle in the spot
            spots[spot_floor][spot_index].SetVehicle(unparked_vehicles[vehicle_index]);
            spots[spot_floor][spot_index].SetParkTime(DateTime.Now);

            unparked_vehicles.RemoveAt(vehicle_index);
        }

        public void UnparkVehicle(int spot_floor, int spot_index) {
            if (spot_floor >= spots.Count || spot_floor < 0) {
                Console.WriteLine("Parking floor does not exist");
                return;
            }
            if (spot_index >= spots[spot_floor].Count || spot_index < 0) {
                Console.WriteLine("Spot index does not exist for the selected floor");
                return;
            }
            if (spots[spot_floor][spot_index].GetVehicle() == null) {
                Console.WriteLine("Parking spot does not have a vehicle");
                return;
            }

            Vehicle vehicle = spots[spot_floor][spot_index].GetVehicle();
            DateTime startTime = spots[spot_floor][spot_index].GetParkTime();
            PriceStrategy strategy = PriceStrategy.GetPriceStrategy();
            TimeSpan duration = DateTime.Now - startTime;



            double ticket = strategy.GenerateTicket(duration.TotalHours, vehicle.GetType());
            Console.WriteLine("Sucessfully Unparked " + vehicle.GetName());
            spots[spot_floor][spot_index].SetVehicle(null);

        }

        public void AddUnparkedVehicle(Vehicle vehicle) {
            unparked_vehicles.Add(vehicle);
        }

        public void AddSpot(int floor, int size) {
            if(spots.Count <= floor) {
                Console.WriteLine("Floor does not exist");
                return;
            }
            Spot spot = new Spot(size);
            spots[floor].Add(spot);
            Console.WriteLine("Created new Spot at floor: " + floor + " and Size: " + size);
            
        }

        public void AddFloor() {
            spots.Add(new List<Spot>{});
            Console.WriteLine("Created new floor: " + (spots.Count - 1));
        }

        public void Status() {
            for(int i = 0; i < spots.Count; i++) {
                Console.WriteLine("\nFloor " + i + ":");
                for(int j = 0; j < spots[i].Count; j++) {
 
                    Console.Write("\nSpot: " + j + " Size: " + spots[i][j].GetSize() + " - Occupied By: " + spots[i][j].GetVehicleName());
                }
                Console.WriteLine("");
            }
        }

        public void UnparkedVehiclesStatus()
        {
            for (int i = 0; i < unparked_vehicles.Count; i++)
            {
                Console.WriteLine(i + ": " + unparked_vehicles[i].GetName() + " license plate: " + unparked_vehicles[i].GetLicensePlate());
            }
        }

        
    }
}
