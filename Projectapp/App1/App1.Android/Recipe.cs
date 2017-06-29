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
    abstract class Recipe
    {
        
    }
    class Banana_split : Recipe
    {
        private string recipe_id;
        //Will return a query for the database
        string Query = @"SELECT * FROM recipe WHERE recept_name = 'banana split')";

            }
    class Milkshake : Recipe
    {
        //Will return a query for the database
        
    }
    class Irish_coffee : Recipe
    {
        //Will return a query for the database
        
    }
    class Biefstuk : Recipe
    {
        //Will return a query for the database
        string Query = @"SELECT * FROM recipe WHERE recept_name = 'biefstuk')";
    }
    class Kip_madras : Recipe
    {
        //Will return a query for the database
        
    }
    class Chili_con_carne : Recipe
    {
        //Will return a query for the database
        
    }
    class Zandkoekjes : Recipe
    {
        //Will return a query for the database
        string Query = @"SELECT * FROM recipe WHERE recept_name = 'zandkoekjes')";
    }
    class Cake : Recipe
    {
        //Will return a query for the database
        
    }
    class Worstenbroodjes : Recipe
    {
        //Will return a query for the database
        
    }
    class Omelet : Recipe
    {
        //Will return a query for the database
        string Query = @"SELECT * FROM recipe WHERE recept_name = 'omelet')";
    }
    class Brood : Recipe
    {
        //Will return a query for the database
         
    }
    class Aardbeiensmoothie : Recipe
    {
        //Will return a query for the database
         
    }
}