using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compooser
{
    abstract class PizzaComponent
    {
        public abstract void Display();
    }

    class Topping : PizzaComponent
    {
        private string name;

        public Topping(string name)
        {
            this.name = name;
        }

        public override void Display()
        {
            Console.WriteLine($"- {name}");
        }
    }

    class Pizza : PizzaComponent
    {
        private string name;
        private List<PizzaComponent> toppings = new List<PizzaComponent>();

        public Pizza(string name)
        {
            this.name = name;
        }

        public void AddTopping(PizzaComponent topping)
        {
            toppings.Add(topping);
        }

        public void RemoveTopping(PizzaComponent topping)
        {
            toppings.Remove(topping);
        }

        public override void Display()
        {
            Console.WriteLine($"Pizza: {name}");
            Console.WriteLine("Toppings:");

            foreach (PizzaComponent topping in toppings)
            {
                topping.Display();
            }

            Console.WriteLine();
        }
    }
    class Client
    {
        public void ClientCode(PizzaComponent component)
        {
            component.Display();
        }
    }
}
