using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarBucks : IMakeACoffee //moq
    {
        public bool CheckIngridientAvailability()
        {
            return true;
        }
        public string CoffeeMaking(int sugerPerSpoon, int coffeePowder)
        {
            throw new NotImplementedException();
        }
    }
    public class StubStarBucks : IMakeACoffee //stub
    {
        public bool CheckIngridientAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugerPerSpoon, int coffeePowder)
        {
            return "Your Order Is Received";
        }
    }
    public class FakeStarBucks : IMakeACoffee //fake
    {
        public bool CheckIngridientAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugerPerSpoon, int coffeePowder)
        {
            return "Your Order Is Received";
        }
    }
}