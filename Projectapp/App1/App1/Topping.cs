using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFApp1
{
    abstract class APizza
    {
        abstract public string Name();
        //abstract public void getDescription();
    }

    //class Pizza : APizza
    //{
    //    private string adding;
    //    public override void getDescription()
    //    {
    //        adding = 
    //    }
    //}

    class ToppingDecorator : APizza
    {
        private APizza tempPizza;
        //private string Bottom;
        public ToppingDecorator(APizza newPizza)
        {
            tempPizza = newPizza;
        }
        public override string Name()
        {
            return "De bodem van je pizza, hier ga je dingen aan toevoegen";
        }
        //public override void getDescription()
        //{
        //    // Console.WriteLine(Bottom);
        //    tempPizza.getDescription();
        //}
    }

    class Mozzarella : ToppingDecorator
    {

        private string Topping;
        public Mozzarella(APizza newPizza) : base(newPizza)
        {
            Topping = "Added Mozzarella";
        }
        public override string Name()
        {
            return "De bodem van je pizza, hier ga je dingen aan toevoegen";
        }
        //public override void getDescription()
        //{
        //    base.getDescription();
        //}
    }

    class Chicken : ToppingDecorator
    {

        private string Topping;
        public Chicken(APizza newPizza) : base(newPizza)
        {
            Topping = "Added Chicken";
        }
        public override string Name()
        {
            return "Chicken : Good with grilled cheese";
        }
        //public override void getDescription()
        //{
        //    base.getDescription();
        //}
    }

    class Pepperoni : ToppingDecorator
    {

        private string Topping;
        public Pepperoni(APizza newPizza) : base(newPizza)
        {
            Topping = "A Pepperoni pizza ^.^";
        }
        public override string Name()
        {
            return "De bodem van je pizza, hier ga je dingen aan toevoegen";
        }
        //public override void getDescription()
        //{
        //    base.getDescription();
        //}
    }

    class FourCheese : ToppingDecorator
    {

        private string Topping;
        public FourCheese(APizza newPizza) : base(newPizza)
        {
            Topping = "A FourCheese pizza ^.^";
        }
        public override string Name()
        {
            return "De bodem van je pizza, hier ga je dingen aan toevoegen";
        }
        //public override void getDescription()
        //{
        //    base.getDescription();
        //}
    }

    class Hawai : ToppingDecorator
    {

        private string Topping;
        public Hawai(APizza newPizza) : base(newPizza)
        {
            Topping = "A Hawai pizza ^.^";
        }
        public override string Name()
        {
            return "De bodem van je pizza, hier ga je dingen aan toevoegen";
        }
        //public override void getDescription()
        //{
        //    base.getDescription();
        //}
    }
        //interface ToppingInfo
        //{
        //    string ExtractName();
        //    string ExtractAanrader();


        //}
        ////Decorator for the toppings of the pizza categorie
        //class Topping : IPizza, ToppingInfo
        //{
        //    string topping_Name;
        //    string topping_Aanrader;
        //    //New temporary pizza
        //    public IPizza tempPizza;

        //    public Topping (IPizza newPizza)
        //    {
        //        tempPizza = newPizza;
        //    }

        //    public string ExtractAanrader()
        //    {

        //        return topping_Aanrader;
        //    }

        //    public string ExtractName()
        //    {
        //        return topping_Name;
        //    }
        //}

        ///*class Mozzarella : Topping
        //{

        //    public Mozzarella(IPizza newPizza) : base(newPizza) 
        //    {
        //        string Name = "Mozzarella";

        //        string Recommandation = "Lekker met kip";
        //    }
        //}
        //*/
        //class Pepperoni : Topping , ToppingInfo
        //{
        //    public Pepperoni(IPizza newPizza) : base(newPizza)
        //    {

        //    }

        //    public new string ExtractAanrader()
        //    {
        //        string topping_aanrader = "Pepperoni is erg lekker bij aids";

        //        return topping_aanrader;
        //    }

        //    public new string ExtractName()
        //    {
        //        string topping_name = "Pepperoni";

        //        return topping_name;
        //    }
        //}

        //class Chicken : Topping
        //{
        //    public Chicken(IPizza newPizza) : base(newPizza)
        //    {
        //    }
        //}
        //class Shoarma : Topping
        //{
        //    public Shoarma(IPizza newPizza) : base(newPizza)
        //    {
        //    }
        //}
}
