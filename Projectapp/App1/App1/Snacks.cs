using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    public class Snacks : IRecipeCategories
    {
        string snacksName;
        public void setName()
        {
            //Console.WriteLine("Please enter the name of the recipe: ");
            //string snacksName = Convert.ToString(Console.ReadLine());
        }
        public string getName()
        {
            return snacksName;
        }
    }
}