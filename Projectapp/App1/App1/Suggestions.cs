using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    public class Suggestions
    {
        Random rnd = new Random();

        public string GetRandomRecipe()
        {
            List<string> RandomRecipeList = new List<string>
            { "French Toast", "Pancakes", "Scrambled eggs", "Chocolate pudding", "Strawberry pudding", "Vanilla pudding", "Tiramisu", "Brownies", "Popcorn", "Fudge", "Nachos", "Croissants", "Sheperds Pie", "Hamburger", "Chicken soup", "Pasta bolognese" };

            string RandomRecipe = RandomRecipeList[rnd.Next(RandomRecipeList.Count)];

            return RandomRecipe;
        }

    }
}