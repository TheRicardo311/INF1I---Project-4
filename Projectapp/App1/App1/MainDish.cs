using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WPFApp1
{
    public class MainDish : IRecipeCategories
    {
        string MainDishName;
        public void setName()
        {
            //Console.WriteLine("Please enter the name of the recipe: ");
            //string Main = Convert.ToString(Console.ReadLine());
            //MainDishName = Main;
        }

        public string getName()
        {
            return MainDishName;
        }
    }
}