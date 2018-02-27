using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza)
        {
        }

        /// <summary>
        /// extend method doPizza, add tomato to pizza
        /// </summary>
        /// <returns></returns>
        public override string doPizza()
        {
            return _pizza.doPizza() + addTomato();
        }

        private string addTomato()
        {
            return " + Tomato";
        }
    }
}
