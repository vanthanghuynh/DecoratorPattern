using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// This is our component interface. It has doPizza() method that provides a Pizza cake.
    /// </summary>
    interface IPizza
    {
        string doPizza();
    }
}
