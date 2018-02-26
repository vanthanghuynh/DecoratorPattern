using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class PepperDecorator : PizzaDecorator
    {
        public PepperDecorator(IPizza pizza):base(pizza)
        {
        }

        public override string doPizza()
        {
            return _pizza.doPizza() + addPepper();
        }

        private string addPepper()
        {
            return " + Pepper";
        }
    }
}
