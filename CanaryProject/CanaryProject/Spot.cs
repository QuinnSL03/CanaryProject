using System;

namespace CanaryProject
{
    public class Spot {
        private int size = 0;
        private Vehicle vehicle = null;
        private DateTime startParkTime;

        public Spot(int size) {
            this.size = size;
        }

        public Vehicle GetVehicle() {
            return vehicle;
        }

        public void SetVehicle(Vehicle vehicle) {
            this.vehicle = vehicle;
        }

        public int GetSize() {
            return size;
        }

        public string GetVehicleName() {
            if (vehicle != null) {
                return vehicle.GetName();
            }
            return "None";

        }

        public void SetParkTime(DateTime startParkTime) {
            this.startParkTime = startParkTime;
        }

        public DateTime GetParkTime() {
            return startParkTime;
        }

        public string Status() {
            if (GetVehicle() != null) {
                return vehicle.GetName();

            }
            return "Empty";
        }


    }
}