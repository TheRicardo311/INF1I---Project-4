﻿using System;
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
    public class Snacks : IRecipeCategories
    {
        string snacksName;
        public void setName()
        {
            Console.WriteLine("Please enter the name of the recipe: ");
            Console.ReadLine();
            return snacksName;
        }
        public string getName()
        {
            snacksName = value;
        }
    }
}