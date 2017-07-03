using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Program
    {
        abstract class APizza
        {
            abstract public void getDescription();
        }
        
        class Pizza : APizza
        {
            private string adding;
            public override void getDescription()
            {
                adding = "BAKING....................";
                Console.WriteLine(adding);
            }
        }

        class ToppingDecorator : APizza
        {
            private APizza tempPizza;
            private string Bottom;
            public ToppingDecorator(APizza newPizza)
            {
                tempPizza = newPizza;
                Bottom = "CREATING..................";
            }
            public override void getDescription()
            {
                Console.WriteLine(Bottom);
                tempPizza.getDescription();
            }
        }

        class Mozzarella : ToppingDecorator
        {

            private string Topping;
            public Mozzarella(APizza newPizza) : base(newPizza)
            {
                Topping = "A Mozzarella pizza ^.^";
            }
            public override void getDescription()
            {
                base.getDescription();
                Console.WriteLine(Topping);
            }
        }

        class Chicken : ToppingDecorator
        {

            private string Topping;
            public Chicken(APizza newPizza) : base(newPizza)
            {
                Topping = "A Chicken pizza ^.^";
            }
            public override void getDescription()
            {
                base.getDescription();
                Console.WriteLine(Topping);
            }
        }

        class Pepperoni : ToppingDecorator
        {

            private string Topping;
            public Pepperoni(APizza newPizza) : base(newPizza)
            {
                Topping = "A Pepperoni pizza ^.^";
            }
            public override void getDescription()
            {
                base.getDescription();
                Console.WriteLine(Topping);
            }
        }

        class FourCheese : ToppingDecorator
        {

            private string Topping;
            public FourCheese(APizza newPizza) : base(newPizza)
            {
                Topping = "A FourCheese pizza ^.^";
            }
            public override void getDescription()
            {
                base.getDescription();
                Console.WriteLine(Topping);
            }
        }

        class Hawai : ToppingDecorator
        {

            private string Topping;
            public Hawai(APizza newPizza) : base(newPizza)
            {
                Topping = "A Hawai pizza ^.^";
            }
            public override void getDescription()
            {
                base.getDescription();
                Console.WriteLine(Topping);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write a digit ranging from 1 to 5: ");
            string Choice = Console.ReadLine();

            switch (Choice) {
                case "1":
                    APizza myPizza = new Mozzarella(new Pizza());
                    myPizza.getDescription();
                    Console.ReadLine();
                    break;

                case "2":
                    APizza myPizza2 = new Chicken(new Pizza());
                    myPizza2.getDescription();
                    System.Console.ReadLine();
                    break;
                case "3":
                    APizza myPizza3 = new Pepperoni(new Pizza());
                    myPizza3.getDescription();
                    System.Console.ReadLine();
                    break;
                case "4":
                    APizza myPizza4 = new FourCheese(new Pizza());
                    myPizza4.getDescription();
                    System.Console.ReadLine();
                    break;
                case "5":
                    APizza myPizza5 = new Hawai(new Pizza());
                    myPizza5.getDescription();
                    System.Console.ReadLine();
                    break;

            }


        }

    }
}
