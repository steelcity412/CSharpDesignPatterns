using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternExample
{
    /// <summary>
    /// This is a pizza provider class which will get pizza for their clients.
    /// </summary>
    public class PizzaProvider : IPizza
    {
        public void GetNonVegPizza()
        {
            GetNonVegPizza();
            Console.WriteLine("Getting Non Veg Pizza.");
        }

        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza.");
        }

        private void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Pizza Toppings.");
        }
        
    }
}
