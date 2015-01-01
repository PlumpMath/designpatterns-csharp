using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Desserts.IceCream.Base {
    public class Dish : IIceCream{
        const string DESCRIPTION = "Dish";

        public List<string> Ingredients() {
            return new List<string> { DESCRIPTION };
        }
    }
}
