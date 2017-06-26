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
    abstract class RecipeFactory
    {
        public abstract Recipe Create(string name, int id_number, string[,] ingredientlist, int rating, string category);
    }

    class ConcreteRecipeFactory : RecipeFactory
    {
        public override Recipe Create(string name, int id_number, string[,] ingredientlist, int rating, string category)
        {
            if ((id_number == 1))
            {
                return new Banana_split();
            }
            if ((id_number == 2))
            {
                return new Milkshake();
            }
            if ((id_number == 3))
            {
                return new Irish_coffee();
            }
            if ((id_number == 4))
            {
                return new Biefstuk();
            }
            if ((id_number == 5))
            {
                return new Kip_madras();
            }
            if ((id_number == 6))
            {
                return new Chili_con_carne();
            }
            if ((id_number == 7))
            {
                return new Zandkoekjes();
            }
            if ((id_number == 8))
            {
                return new Cake();
            }
            if ((id_number == 9))
            {
                return new Worstenbroodjes();
            }
            if ((id_number == 10))
            {
                return new Omelet();
            }
            if ((id_number == 11))
            {
                return new Brood();
            }
            if ((id_number == 12))
            {
                return new Aardbeiensmoothie();
            }
        }
    }


/*

    public class ConcreteRecipe
    {
        public string Name { get; private set; }
        public int ID_number { get; private set; }
        public string[,] Ingredientlist { get; private set; }
        public int Rating { get; private set; }
        public string Category { get; private set; }

        //Create the class for Recipes
        public ConcreteRecipe ConcreteRecipe(string name, int id_number, string[,] ingredientlist, int rating, string category)
        {
            Name = name;
            ID_number = id_number;
            Ingredientlist = ingredientlist;
            Rating = rating;
            Category = category;
        }

    }

<<<<<<< HEAD
    */
=======
    public static class RecipeFactory
    {
        //public static Recipe CreateNewRecipe()
        //{
        //    //return new Recipe("taart", 1, ["appel", "taart"], 72, "Gebak" );
        //}
        
    }
>>>>>>> 55fa29131f71fce2c7ba0e9cd34a0d0188eb53a5

}

