using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Vehicles.Car.Actions;


namespace DesignPatterns.Vehicles.Car {
    public static class DriverFactory {
        public static Driver GetDriver() {
            ICar car = CarFactory.GetCar( DriverType.Buyer );
            car.Start();

            IAction forwardAction = new ForwardAction( car );
            IAction reverseAction = new ReverseAction( car );
            IAction steerLeftAction = new SteerLeftAction( car );
            IAction steerRightAction = new SteerRightAction( car );

            Driver driver = new Driver(
                forwardAction,
                reverseAction,
                steerLeftAction,
                steerRightAction
            );

            return driver;
        }
    }
}
