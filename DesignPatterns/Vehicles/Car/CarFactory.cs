using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Vehicles.Car {
    
    public static class CarFactory {
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
