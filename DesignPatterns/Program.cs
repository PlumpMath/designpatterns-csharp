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

        /// <summary>
        /// Acts as the client in the Proxy Pattern
        /// </summary>
        private static void ProxyPattern() {
            Console.WriteLine( "===== Proxy Pattern Example =====" );
            
            Console.WriteLine( "Starting the car as a buyer." );
            ICar boughtCar = CarFactory.GetCar( DriverType.Buyer );     // Returns a proxy
            boughtCar.Start();                                          // Car starts (passes security check in the proxy)

            Console.WriteLine( "Starting the car as a demo driver." );
            ICar demoCar = CarFactory.GetCar( DriverType.Demo );        // Returns a subject
            demoCar.Start();                                            // Car starts (the subject does not have a security check)

            Console.WriteLine( "Starting the car as a theft." );
            ICar stolenCar = CarFactory.GetCar( DriverType.Theft );     // Returns a proxy
            stolenCar.Start();                                          // Car does not start (fails security check in the proxy)

            Console.WriteLine();
        }

        /// <summary>
        /// Acts as the client in the Command Pattern
        /// </summary>
        private static void CommandPattern() {
            Console.WriteLine( "===== Command Pattern Example =====" );

            Console.WriteLine( "Getting a driver." );
            Driver driver = DriverFactory.GetDriver();      // DriverFactory class sets up the Invoker for us

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
