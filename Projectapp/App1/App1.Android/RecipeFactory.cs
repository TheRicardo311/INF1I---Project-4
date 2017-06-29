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
    public class Recipe
    {
        public string Name { get; private set; }
        public int ID_number { get; private set; }
        public string[,] Ingredientlist { get; private set; }
        public int Rating { get; private set; }
        public string Category { get; private set; }

        //Create the class for Recipes
        public Recipe(string name, int id_number, string[,] ingredientlist, int rating, string category)
        {
            Name = name;
            ID_number = id_number;
            Ingredientlist = ingredientlist;
            Rating = rating;
            Category = category;
        }

    }

    public static class RecipeFactory
    {
        //public static Recipe CreateNewRecipe()
        //{
        //    //return new Recipe("taart", 1, ["appel", "taart"], 72, "Gebak" );
        //}
        
    }

}

