using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza chickenPizza = new ChickenPizza();
            IPizza cheesePizza = new CheesePizza();

            Console.WriteLine(chickenPizza.doPizza());
            Console.WriteLine(cheesePizza.doPizza());

            TomatoDecorator chickenTomatoPizza = new TomatoDecorator(chickenPizza);
            Console.WriteLine(chickenTomatoPizza.doPizza());

            PepperDecorator cheesePepperDecorator = new PepperDecorator(cheesePizza);
            Console.WriteLine(cheesePepperDecorator.doPizza());

            PepperDecorator chickenTomatoPepperPizza = new PepperDecorator(chickenTomatoPizza);
            Console.WriteLine(chickenTomatoPepperPizza.doPizza());
        }
    }
}
