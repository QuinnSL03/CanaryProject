using System;

namespace CanaryProject {
    public class Car : Vehicle {
        public Car(string licensePlate) {
            SetSize(1);
            SetName("Car");
            SetType(1);
            SetLicensePlate(licensePlate);
        }
    }
}
