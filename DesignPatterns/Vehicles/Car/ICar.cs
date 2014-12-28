using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Vehicle.Car {
    public interface ICar {
        bool StartCar();
 
        bool Forward();
        bool Reverse();
        bool Left();
        bool Right();
    }
}
