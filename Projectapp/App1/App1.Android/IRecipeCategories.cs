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
    interface IRecipeCategories
    {//Initializing recipe methods, this will probably be changed later on
        void setName();
        string getName();
        
    }
}