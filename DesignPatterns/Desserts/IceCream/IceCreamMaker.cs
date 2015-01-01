using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Desserts.IceCream.Base;
using DesignPatterns.Desserts.IceCream.Ingredients;

namespace DesignPatterns.Desserts.IceCream {
    /// <summary>
    /// Uses the Decorator Pattern to put ice cream ingredients together.
    /// </summary>
    public static class IceCreamMaker {
        public static IIceCream MakeIceCream(IceCreamType iceCreamType) {
            IIceCream iceCream;

            switch( iceCreamType ) {
                case IceCreamType.Chocolate:
                    iceCream = new IceCreamCone();
                    iceCream = new ChocolateIceCreamScoop( iceCream );
                    break;

                case IceCreamType.Strawberry:
                    iceCream = new IceCreamCone();
                    iceCream = new StrawberryIceCreamScoop( iceCream );
                    break;

                case IceCreamType.Vanilla:
                    iceCream = new IceCreamCone();
                    iceCream = new VanillaIceCreamScoop( iceCream );
                    break;

                case IceCreamType.BananaSplit:
                    iceCream = new Dish();
                    iceCream = new Banana( iceCream );
                    iceCream = new ChocolateIceCreamScoop( iceCream );
                    iceCream = new StrawberryIceCreamScoop( iceCream );
                    iceCream = new VanillaIceCreamScoop( iceCream );
                    break;

                case IceCreamType.TripleDeluxe:
                    iceCream = new IceCreamCone();
                    iceCream = new ChocolateIceCreamScoop( iceCream );
                    iceCream = new StrawberryIceCreamScoop( iceCream );
                    iceCream = new VanillaIceCreamScoop( iceCream );
                    break;

                default:
                    iceCream = new IceCreamCone();
                    break;
            }

            return iceCream;
        }
    }
}
