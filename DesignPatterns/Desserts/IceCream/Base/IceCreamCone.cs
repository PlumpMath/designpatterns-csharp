using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Desserts.IceCream.Base {
    public class IceCreamCone : IIceCream{
        string DESCRIPTION = "Ice cream cone";

        public List<string> Ingredients() {
            return new List<string> { DESCRIPTION };
        }
    }
}
