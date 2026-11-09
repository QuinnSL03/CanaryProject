using System;
using System.Collections.Generic;

namespace CanaryProject{
    public class PriceStrategy {
        private static PriceStrategy strategy = null;
        private Dictionary<int, double> rates = new Dictionary<int, double>();
        private double fee = 0;
  
        public static PriceStrategy GetPriceStrategy() {
            if(strategy == null) {
                strategy = new PriceStrategy();
            }

            return strategy;
        }

        public double GetHourlyRate(int vehicleType) {
            return rates[vehicleType];
        }

        public double GetFee() {
            return fee;
        }

        public void SetFee(double fee) {
            this.fee = fee;
        }


        public void AddHourlyRate(int vehicleType, double hourlyRate) {
            if (hourlyRate < 0) {
                Console.WriteLine("hourly rate can't be negative");
                return;
            }
            rates.Add(vehicleType, hourlyRate);
        }

        public double GenerateTicket(double duration, int vehicleType) { 
            double ticket;
            double dollarPerHour = GetHourlyRate(vehicleType);

            ticket = Math.Round((dollarPerHour * (duration+1)) + fee, 2);
            Console.WriteLine("\nYour ticket is: ");
            Console.WriteLine("Hours billed: " + Math.Ceiling(duration));
            Console.WriteLine("Hourly rate: $" + dollarPerHour);
            Console.WriteLine("Fee: $" + fee);
            Console.WriteLine("Total amount owed: $" + ticket);
            return ticket;
        }

    }
}
