using System;

namespace CanaryProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            PriceStrategy strategy = PriceStrategy.GetPriceStrategy();
            ParkingGarage garage = ParkingGarage.GetGarage();

            strategy.SetFee(5);
            strategy.AddHourlyRate(0, 1);
            strategy.AddHourlyRate(1, 2);
            strategy.AddHourlyRate(2, 3);

            Console.WriteLine("Building garage...");
            Factory.CreateFloor();
            Factory.CreateFloor();
            Factory.CreateFloor();

            //size small = 0, medium = 1, large = 2
            Factory.CreateSpot(3, 1);
            Factory.CreateSpot(0,1);
            Factory.CreateSpot(0,2);
            Factory.CreateSpot(0,1);
            Factory.CreateSpot(1, 0);
            Factory.CreateSpot(1, 1);
            Factory.CreateSpot(1, 0);
            Factory.CreateSpot(2, 2);
            Factory.CreateSpot(2, 2);
            Factory.CreateSpot(2, 2);

            //vehicle type 0 = bike, type 1 = car, type 2 = truck
            Factory.CreateVehicle(1, "JTC4393");
            Factory.CreateVehicle(2, "FJ3293");
            Factory.CreateVehicle(1, "293402");
            Factory.CreateVehicle(0, "Bike1");

         
            garage.UnparkedVehiclesStatus();
           
            Console.WriteLine("Parking vehicles:");

           
            garage.ParkVehicle(0, 0, 0);
          
            garage.ParkVehicle(0, 2, 1);

            garage.ParkVehicle(2, 2, 0);

            garage.Status();

            garage.UnparkVehicle(0, 0);

            garage.UnparkVehicle(0, 2);

            garage.UnparkVehicle(2, 2);

            garage.Status();




        }
    }
}
