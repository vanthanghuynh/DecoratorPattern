﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class MushroomDecorator : PizzaDecorator
    {
        public MushroomDecorator(IPizza pizza):base(pizza)
        {
        }
     
        public override string doPizza()
        {
            return _pizza.doPizza() + addMushroom();
        }

        private string addMushroom()
        {
            return " + Mushroom";
        }
    }
}
