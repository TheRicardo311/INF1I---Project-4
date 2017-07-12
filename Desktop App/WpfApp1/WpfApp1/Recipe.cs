using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace WPFApp1
{

    public interface Recipe
    {
        string ReturnName();
        string ReturnCategory();
        string ReturnIngredients();
        string ReturnDescription();
        string ReturnImage();
        string ReturnRating();
    }
    public class dbFrench_toast : Recipe
    {
        //Type declaration
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;
        string recipe_image;
        string recipe_rating;

        //Create and return recipe_name
        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = French Toast";

            return recipe_name;
        }
        
        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = French Toast";

            return recipe_category;
        }
        
        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = French Toast";

            return recipe_ingredients;
        }
        
        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = French Toast";
            return recipe_description;
        }

        public string ReturnImage()
        {
            string recipe_image = "French Toast.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = French Toast";

            return recipe_rating;
        }
    }
    public class dbPancakes : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Pancakes";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Pancakes";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Pancakes";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Pancakes";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Pancakes.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Pancakes";

            return recipe_rating;
        }
    }
    public class dbScrambled_eggs : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Scrambled eggs";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Scrambled eggs";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Scrambled eggs";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Scrambled eggs";

            return recipe_description;
        }

        public string ReturnImage()
        {
            string recipe_image = "Scrambled eggs.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Scrambled eggs";

            return recipe_rating;
        }
    }
    public class dbCroissants : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Croissants";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Croissants";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Croissants";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Croissants";
                
            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Croissants.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Croissants";

            return recipe_rating;
        }
    }
    public class dbChocolate_pudding : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Chocolate pudding";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Chocolate pudding";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Chocolate pudding";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Chocolate pudding";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Chocolate pudding.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Chocolate pudding";

            return recipe_rating;
        }
    }
    public class dbStrawberry_pudding : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Strawberry pudding";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Strawberry pudding";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Strawberry pudding";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Strawberry pudding";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Strawberry pudding.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Strawberry pudding";

            return recipe_rating;
        }
    }
    public class dbVanilla_pudding : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Vanilla pudding";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Vanilla pudding";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Vanilla pudding";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Vanilla pudding";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Vanilla pudding.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Vanilla pudding";

            return recipe_rating;
        }
    }
    public class dbTiramisu : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Tiramisu";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Tiramisu";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Tiramisu";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Tiramisu";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Tiramisu.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Tiramisu";

            return recipe_rating;
        }
    }
    public class dbBrownies : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Brownies";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Brownies";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Brownies";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Brownies";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Brownies.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Brownies";

            return recipe_rating;
        }
    }
    public class dbPopcorn : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Popcorn";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Popcorn";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Popcorn";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Popcorn";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Popcorn.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Popcorn";

            return recipe_rating;
        }
    }
    public class dbFudge : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Fudge";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Fudge";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Fudge";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Fudge";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Fudge.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT recipe_name FROM recept WHERE recipe_name = Fudge";

            return recipe_rating;
        }
    }
    public class dbNachos : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Nachos";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Nachos";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Nachos";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Nachos";
            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Nachos.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Nachos";

            return recipe_rating;
        }
    }
    public class dbShepherds_pie : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Sheperds pie";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Sheperds pie";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Sheperds pie";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Sheperds pie";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Shepherds pie.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Sheperds pie";

            return recipe_rating;
        }
    }
    public class dbHamburger : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Hamburger";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Hamburger";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Hamburger";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Hamburger";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Hamburger.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Hamburger";

            return recipe_rating;
        }
    }
    public class dbChicken_soup : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Chicken soup";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Chicken soup";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Chicken soup";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Chicken soup";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Chicken soup.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT recipe_name FROM recept WHERE recipe_name = Chicken soup";

            return recipe_rating;
        }
    }
    public class dbPasta_bolognese : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "SELECT recipe_name FROM recept WHERE recipe_name = Pasta bolognese";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "SELECT category FROM recept WHERE recipe_name = Pasta bolognese";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "SELECT ingredient_list FROM recept WHERE recipe_name = Pasta bolognese";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "SELECT preparation FROM recept WHERE recipe_name = Pasta bolognese";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Pasta bolognese.jpg";

            return recipe_image;
        }

        public string ReturnRating()
        {
            string recipe_rating = "SELECT rating FROM recept WHERE recipe_name = Pasta bolognese";

            return recipe_rating;
        }
    }
}