using System;

namespace CanaryProject {
    public class Car : Vehicle {
        public Car(string licensePlate) {
            SetSize(1);
            SetName("Car");
            SetLicensePlate("licensePlate");
        }
    }
}
