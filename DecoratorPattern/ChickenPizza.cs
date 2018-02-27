using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// Concrete class ChickenPizza implements the interface IPizza
    /// </summary>
    class ChickenPizza : IPizza
    {
        public string doPizza()
        {
            return "I am a Chicken Pizza";
        }
    }
}
