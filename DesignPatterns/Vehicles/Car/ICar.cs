using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Vehicles.Car {
    public interface ICar {
        bool Start();
 
        bool Forward();
        bool Reverse();
        bool Left();
        bool Right();
    }
}
