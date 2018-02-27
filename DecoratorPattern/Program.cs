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
            // create chicken pizza
            IPizza chickenPizza = new ChickenPizza();
            Console.WriteLine(chickenPizza.doPizza());

            // create cheese pizza
            IPizza cheesePizza = new CheesePizza();
            Console.WriteLine(cheesePizza.doPizza());

            // create chicken pizza with tomato
            TomatoDecorator chickenTomatoPizza = new TomatoDecorator(chickenPizza);
            Console.WriteLine(chickenTomatoPizza.doPizza());

            // create cheese pizza with pepper
            PepperDecorator cheesePepperPizza = new PepperDecorator(cheesePizza);
            Console.WriteLine(cheesePepperPizza.doPizza());

            // create chicken pizza with tomato and pepper
            PepperDecorator chickenTomatoPepperPizza = new PepperDecorator(chickenTomatoPizza);
            Console.WriteLine(chickenTomatoPepperPizza.doPizza());
        }
    }
}
