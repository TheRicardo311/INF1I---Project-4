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
    //The plain pizza class, this is the file the decorator uses to add toppings to
    class PlainPizza : IPizza
    
    {
        //Uses the getDescription method from the IPizza interfacea
        public string getDescription()
        {
            return "Adding";
        }
    }
}

    