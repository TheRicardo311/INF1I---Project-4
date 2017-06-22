using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1.Droid
{
    //Decorator for the toppings of the pizza categorie
    abstract class Topping : IPizza
    {
        //New temporary pizza
        IPizza tempPizza;
        
        public Topping (IPizza newPizza)
        {
            tempPizza = newPizza;
        }

        //Uses the getDescription method from the IPizza interface
        public string getDescription()
        {
            return "Add different toppings";
        }
    }
}