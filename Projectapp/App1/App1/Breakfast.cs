using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFApp1
{
    public class Breakfast : IRecipeCategories
    {
        string breakfastName;
        public void setName()
        {
            //Console.WriteLine("Please enter the name of the recipe: ");
            //string breakfastName = Convert.ToString(Console.ReadLine());
        }
        public string getName()
        {
            return breakfastName;
        }
    }
}