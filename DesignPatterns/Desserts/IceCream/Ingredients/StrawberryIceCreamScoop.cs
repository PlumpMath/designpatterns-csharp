using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Desserts.IceCream.Ingredients {
    public class StrawberryIceCreamScoop : IIceCream {
        private const string DESCRIPTION = "Scoop of strawberry ice cream";
        private IIceCream _currentIceCream;

        public StrawberryIceCreamScoop( IIceCream currentIceCream ) {
            _currentIceCream = currentIceCream;
        }

        public List<string> Ingredients() {
            List<string> currentIngredients = _currentIceCream.Ingredients();
            currentIngredients.Add( DESCRIPTION );

            return currentIngredients;
        }
    }
}
