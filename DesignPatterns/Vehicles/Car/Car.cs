using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Vehicle.Car {
    class Car : ICar {
        bool _isStarted = false;

        public Car() {}

        public bool StartCar() {
            if( _isStarted ) {
                Console.WriteLine( "Car has already started." );
                return false;
            }
            
            _isStarted = true;
            Console.WriteLine( "Car has started." );
            return true;
        }

        public bool Forward() {
            if( !_isStarted ) {
                Console.WriteLine( "Start the car first." );
                return false;
            }

            Console.WriteLine( "Moving forward." );
            return true;
        }

       public bool Reverse() {
            if( !_isStarted ) {
                Console.WriteLine( "Start the car first." );
                return false;
            }

            Console.WriteLine( "Moving in reverse." );
            return true;
        }

        public bool Left() {
            if( !_isStarted ) {
                Console.WriteLine( "Start the car first." );
                return false;
            }

            Console.WriteLine( "Turning left." );
            return true;
        }

        public bool Right() {
            if( !_isStarted ) {
                Console.WriteLine( "Start the car first." );
                return false;
            }

            Console.WriteLine( "Turning right." );
            return true;
        }
    }
}
