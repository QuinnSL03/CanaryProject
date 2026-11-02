using System;

namespace CanaryProject {
    public class Truck : Vehicle {
        public Truck(string licensePlate) {
            SetSize(2);
            SetName("Truck");
            SetLicensePlate("licensePlate");
        }
    }
}