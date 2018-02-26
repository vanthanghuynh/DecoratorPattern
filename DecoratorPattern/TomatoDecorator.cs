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
