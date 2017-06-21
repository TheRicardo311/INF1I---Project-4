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
    abstract class Topping : IPizza
    {
        public IPizza tempPizza;
        public Topping (IPizza newPizza)
        {
            tempPizza = newPizza;
        }


        public string getDescription()
        {
            throw new NotImplementedException();
        }
    }
}