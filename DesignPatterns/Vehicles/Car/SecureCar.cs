using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Vehicle.Car {
    class SecureCar : ICar {
        private ICar _car;
        private bool _hasKey;

        public SecureCar(bool hasKey = false) {
            _car = new Car();
            _hasKey = hasKey;
        }

        public bool StartCar() {
            if( !_hasKey ) {
                Console.WriteLine( "Not allowed to start car without the key!" );
                return false;
            }
            return _car.StartCar();
        }

        public bool Forward() {
            return _car.Forward();
        }

        public bool Reverse() {
            return _car.Reverse();
        }

        public bool Left() {
            return _car.Left();
        }

        public bool Right() {
            return _car.Right();
        }
    }
}
