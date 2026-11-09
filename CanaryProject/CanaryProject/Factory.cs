using System;

namespace CanaryProject {
    public static class Factory {
        public static void CreateVehicle(int type, string licensePlate = null) {
            Vehicle vehicle;
            switch (type) {
                case 0:
                    vehicle = new Bike();
                    //ParkingGarage.GetGarage().AddUnparkedVehicle(new Bike());
                    break;
                case 1:
                    vehicle = new Car(licensePlate);
                    //ParkingGarage.GetGarage().AddUnparkedVehicle(new Car(licensePlate));
                    break;
                case 2:
                    vehicle = new Truck(licensePlate);
                    //ParkingGarage.GetGarage().AddUnparkedVehicle(new Truck(licensePlate));
                    break;

                default:
                    Console.WriteLine("Create vehicle failed, not a valid type");
                    return;
            }

            Console.WriteLine("Created new " + vehicle.GetName());
            ParkingGarage.GetGarage().AddUnparkedVehicle(vehicle);

        }
        public static void CreateSpot(int floor, int size) {
            ParkingGarage.GetGarage().AddSpot(floor, size);
        }

        public static void CreateFloor() {
            ParkingGarage.GetGarage().AddFloor();
        }


            
    }
}
