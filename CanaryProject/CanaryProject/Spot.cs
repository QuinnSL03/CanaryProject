using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CanaryProject {
    public class Spot {
        private int size = 0;
        private Vehicle vehicle = null;
        
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

        public string Status() {
            if (GetVehicle() == null) {
                return "Empty";
            }
            else {
                return vehicle.GetName();
            }
        }
    }

    
}
