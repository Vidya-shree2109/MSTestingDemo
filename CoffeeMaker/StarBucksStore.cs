using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarBucksStore
    {
        public readonly IMakeACoffee service;
        public StarBucksStore(IMakeACoffee coffee)
        {
            this.service = coffee;
        }
        public string OrderCoffee(int sugerPerSpoon, int coffeePowder)
        {
            if (service.CheckIngridientAvailability())
            {
                return service.CoffeeMaking(sugerPerSpoon, coffeePowder);
            }
            return "Sorry! Coffee Is Not Available";
        }
    }
}