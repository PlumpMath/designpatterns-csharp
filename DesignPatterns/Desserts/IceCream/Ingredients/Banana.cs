using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Desserts.IceCream.Ingredients {
    public class Banana : IIceCream {
        private const string DESCRIPTION = "Banana";
        private IIceCream _currentIceCream;

        public Banana( IIceCream currentIceCream ) {
            _currentIceCream = currentIceCream;
        }

        public List<string> Ingredients() {
            List<string> currentIngredients = _currentIceCream.Ingredients();
            currentIngredients.Add( DESCRIPTION );

            return currentIngredients;
        }
    }
}
