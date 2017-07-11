using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public class Singleton
    {
        private static Singleton firstInstance = null;
        
        public static Singleton getInstance()
        {
            if (firstInstance == null)
            {
                firstInstance = new Singleton();
            }

            return firstInstance;
        }
        public List<string> CreateList()
            {
            List<string> RandomRecipeList = new List<string>
            { "French Toast", "Pancakes", "Scrambled eggs", "Chocolate pudding", "Strawberry pudding", "Vanilla pudding", "Tiramisu", "Brownies", "Popcorn", "Fudge", "Nachos", "Croissants", "Sheperds Pie", "Hamburger", "Chicken soup", "Pasta bolognese" };

            return RandomRecipeList;
            }
    }
}