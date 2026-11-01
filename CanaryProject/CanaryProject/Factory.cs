using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CanaryProject {
    public static class Factory {
        public static void CreateVehicle(int type, string licensePlate) {
            switch (type) {
                case 0: 
                    ParkingGarage.GetGarage().AddUnparkedVehicle(new Bike(licensePlate));
                    break;
                case 1: 
                    ParkingGarage.GetGarage().AddUnparkedVehicle(new Car(licensePlate));
                    break;
                case 2: 
                    ParkingGarage.GetGarage().AddUnparkedVehicle(new Truck(licensePlate));
                    break;

                default:
                    Console.WriteLine("Create vehicle failed, not a valid type");
                    break;
            }
        }
        public static void CreateSpot(int floor, int size) {
            ParkingGarage.GetGarage().AddSpot(floor, size);
        }


            
    }
}
