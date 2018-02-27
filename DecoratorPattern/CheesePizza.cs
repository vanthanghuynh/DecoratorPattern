using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// Concrete class CheesePizza implements the interface IPizza
    /// </summary>
    class CheesePizza : IPizza
    {
        public string doPizza()
        {
            return "I am a Cheese Pizza";
        }
    }
}
