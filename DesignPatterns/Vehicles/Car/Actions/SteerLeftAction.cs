using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Vehicles.Car;

namespace DesignPatterns.Vehicles.Car.Actions {
    public class SteerLeftAction : IAction {
        ICar _car;

        public SteerLeftAction( ICar car ) {
            _car = car;
        }

        public bool Execute() {
            return _car.Left();
        }
    }
}
