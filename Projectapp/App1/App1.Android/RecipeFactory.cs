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
        private string name;
        private int id_number;
        private Array ingredientlist;

        //Initiating methods for Recipetypes
        public string getName()
        {
            return name;
        }
        public void setName(string newName)
        {
            name = newName;
        }
        public int getID_number()
        {
            return id_number;
        }
        public void setID_number(int newid_number)
        {
            id_number = newid_number;
        }

        public Array getIngredients()
        {
            return ingredientlist;
        }

        public void setIngredients(Array newIngredientlist)
        {
            ingredientlist = newIngredientlist;
        }
    }
}