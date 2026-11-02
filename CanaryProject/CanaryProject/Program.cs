using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanaryProject
{
    public class Program
    {
        static ParkingGarage garage = null;
        static void Main(string[] args)
        {
            garage = ParkingGarage.GetGarage();

            Factory.CreateFloor();
            Factory.CreateFloor();
            Factory.CreateFloor();
            Factory.CreateSpot(0,1);
            Factory.CreateSpot(0,2);
            Factory.CreateSpot(0,1);
            Factory.CreateSpot(1, 0);
            Factory.CreateSpot(1, 1);
            Factory.CreateSpot(1, 0);
            Factory.CreateSpot(2, 3);
            Factory.CreateSpot(2, 2);
            Factory.CreateSpot(2, 3);
        }
    }
}
