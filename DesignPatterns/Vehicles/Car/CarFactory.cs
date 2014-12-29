using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Vehicles.Car {
    
    public static class CarFactory {
        
        /// <summary>
        /// Creates an object for a client.
        /// Client could receive either a proxy or a real subject (Proxy Pattern)
        /// </summary>
        /// <param name="dt">The type of driver trying to get a car.</param>
        /// <returns>A car object.</returns>
        public static ICar GetCar( DriverType dt ) {
            switch( dt ) {
                case DriverType.Buyer:
                    return new SecureCar( true );

                case DriverType.Demo:
                    return new Car();

                case DriverType.Theft:
                default:
                    return new SecureCar( false );
            }
        }
    }
}
