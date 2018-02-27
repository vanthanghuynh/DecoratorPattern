using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// Abstract class PizzaDecorator implements the interface IPizza and has an attribute of type IPizza
    /// </summary>
    abstract class PizzaDecorator : IPizza
    {
        protected IPizza _pizza;

        /// <summary>
        /// receive an instance of IPizza to initialize the attrubte _pizza
        /// </summary>
        /// <param name="pizza"></param>
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        /// <summary>
        /// abstract method to extend
        /// </summary>
        /// <returns></returns>
        abstract public string doPizza();       
   
    }
}
