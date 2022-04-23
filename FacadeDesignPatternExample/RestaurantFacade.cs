using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternExample
{
    /// <summary>
    /// Restaurant facade class will be used by the client to order different pizzas or breads.
    /// </summary>
    public class RestaurantFacade
    {
        private IPizza _PizzaProvider;
        private IBread _BreadProvider;

        public RestaurantFacade()
        {
            _PizzaProvider = new PizzaProvider();
            _BreadProvider = new BreadProvider();
        }

        public void GetNonVegPizza()
        {
            _PizzaProvider.GetNonVegPizza();
        }

        public void GetVegPizza()
        {
            _PizzaProvider.GetVegPizza();
        }

        public void GetGarlicBread()
        {
            _BreadProvider.GetGarlicBread();
        }

        public void GetCheesyGarlicBread()
        {
            _BreadProvider.GetCheesyGarlicBeard();
        }
    }
}
