using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Vehicles.Car.Actions;


namespace DesignPatterns.Vehicles.Car {
    public static class DriverFactory {

        /// <summary>
        /// Prepares invoker object in Command Pattern for the client
        /// </summary>
        /// <returns>Invoker object</returns>
        public static Driver GetDriver() {
            // Set up receiver
            ICar car = CarFactory.GetCar( DriverType.Buyer );
            car.Start();

            // Create the commands
            IAction forwardAction = new ForwardAction( car );
            IAction reverseAction = new ReverseAction( car );
            IAction steerLeftAction = new SteerLeftAction( car );
            IAction steerRightAction = new SteerRightAction( car );

            // Create the invoker
            Driver driver = new Driver(
                forwardAction,
                reverseAction,
                steerLeftAction,
                steerRightAction
            );

            // Return invoker to client
            return driver;
        }
    }
}
