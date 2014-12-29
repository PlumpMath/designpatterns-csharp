using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Vehicles;
using DesignPatterns.Vehicles.Car;

namespace DesignPatterns {
    class Program {
        public static void Main() {
            ProxyPattern();
            CommandPattern();

            Console.WriteLine();
            Console.WriteLine( "Press any key to close." );
            Console.ReadKey();
        }

        private static void ProxyPattern() {
            Console.WriteLine( "===== Proxy Pattern Example =====" );
            
            Console.WriteLine( "Starting the car as a buyer." );
            ICar boughtCar = CarFactory.GetCar( DriverType.Buyer );
            boughtCar.Start();

            Console.WriteLine( "Starting the car as a demo driver." );
            ICar demoCar = CarFactory.GetCar( DriverType.Demo );
            demoCar.Start();

            Console.WriteLine( "Starting the car as a theft." );
            ICar stolenCar = CarFactory.GetCar( DriverType.Theft );
            stolenCar.Start();

            Console.WriteLine();
        }

        private static void CommandPattern() {
            Console.WriteLine( "===== Command Pattern Example =====" );

            Console.WriteLine( "Getting a driver." );
            Driver driver = DriverFactory.GetDriver();

            Console.WriteLine( "Asking driver to drive." );
            Console.WriteLine();

            driver.Forward();
            driver.Forward();
            driver.Reverse();
            driver.Left();
            driver.Left();
            driver.Right();
            driver.WhereAmI();
            Console.WriteLine();

            driver.Forward();
            driver.Reverse();
            driver.Reverse();
            driver.Left();
            driver.Right();
            driver.Right();
            driver.WhereAmI();
            Console.WriteLine();
            
            driver.Forward();
            driver.Reverse();
            driver.Left();
            driver.Right();
            driver.WhereAmI();
            Console.WriteLine();
        }
    }
}
