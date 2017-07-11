using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFApp1
{
    public class Desert : IRecipeCategories
    {
        string desertName;
        public void setName()
        {
            //Console.WriteLine("Please enter the name of the recipe: ");
            //string desertName = Convert.ToString(Console.ReadLine());
        }
        public string getName()
        {
            return desertName;
        }
    }
}