using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternExample
{
    /// <summary>
    /// This is the interface specific to the Pizza
    /// </summary>
    public interface IPizza
    {
        void GetVegPizza();
        void GetNonVegPizza();
    }
}
