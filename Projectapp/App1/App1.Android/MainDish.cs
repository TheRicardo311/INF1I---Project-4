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
    public class MainDish : IRecipeCategories
    {
        string MainDishName;
        public void setName()
        {
            Console.WriteLine("Please enter the name of the recipe: ");
            string Main = Convert.ToString(Console.ReadLine());
            MainDishName = Main;
        }

        public string getName()
        {
            return MainDishName;
        }
    }
}