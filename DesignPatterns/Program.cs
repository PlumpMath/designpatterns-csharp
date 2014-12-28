using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Vehicle;
using DesignPatterns.Vehicle.Car;

namespace DesignPatterns {
    class Program {
        public static void Main() {
            ProxyPattern();

            Console.ReadKey();
        }

        private static void ProxyPattern() {
            Console.WriteLine( "Starting the car as a buyer." );
            ICar boughtCar = CarDealer.GetCar( DriverType.Buyer );
            boughtCar.StartCar();

            Console.WriteLine( "Starting the car as a demo driver." );
            ICar demoCar = CarDealer.GetCar( DriverType.Demo );
            demoCar.StartCar();

            Console.WriteLine( "Starting the car as a theft." );
            ICar stolenCar = CarDealer.GetCar( DriverType.Theft );
            stolenCar.StartCar();
        }
    }
}
