using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    abstract class Recipe
    {
        //Type declaration
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;
    }
    class French_toast : Recipe
    {
        //Create and return recipe_name
        public string ReturnNameFrench_toast()
        {
            string recipe_name = "French toast";

            return recipe_name;
        }
        
        public string ReturnCategoryFrench_toast()
        {
            string recipe_category = "Breakfast";

            return recipe_category;
        }
        
        public string ReturnIngredientsFrench_toast()
        {
            string recipe_ingredients = "Bob1";

            return recipe_ingredients;
        }
        
        public string ReturnDescriptionFrench_toast()
        {
            string recipe_description = "Henk1";

            return recipe_description;
        }
        
    }
    class Pancakes : Recipe
    {
        public string ReturnNamePancakes()
        {
            string recipe_name = "Pancakes";

            return recipe_name;
        }

        public string ReturnCategoryPancakes()
        {
            string recipe_category = "Breakfast";

            return recipe_category;
        }

        public string ReturnIngredientsPancakes()
        {
            string recipe_ingredients = "Bob2";

            return recipe_ingredients;
        }

        public string ReturnDescriptionPancakes()
        {
            string recipe_description = "Henk2";

            return recipe_description;
        }
    }
    class Scrambled_eggs : Recipe
    {
        public string ReturnNameScrambled_eggs()
        {
            string recipe_name = "Scrambled eggs";

            return recipe_name;
        }

        public string ReturnCategoryScrambled_eggs()
        {
            string recipe_category = "Breakfast";

            return recipe_category;
        }

        public string ReturnIngredientsScrambled_eggs()
        {
            string recipe_ingredients = "Bob3";

            return recipe_ingredients;
        }

        public string ReturnDescriptionScrambled_eggs()
        {
            string recipe_description = "Henk3";

            return recipe_description;
        }
    }
    class Croissants : Recipe
    {
        public string ReturnNameCroissants()
        {
            string recipe_name = "Croissants";

            return recipe_name;
        }

        public string ReturnCategoryCroissants()
        {
            string recipe_category = "Breakfast";

            return recipe_category;
        }

        public string ReturnIngredientsCroissants()
        {
            string recipe_ingredients = "Bob4";

            return recipe_ingredients;
        }

        public string ReturnDescriptionCroissants()
        {
            string recipe_description = "Henk4";

            return recipe_description;
        }
    }
    class Chocolate_pudding : Recipe
    {
        public string ReturnNameChocolate_pudding()
        {
            string recipe_name = "Chocolate pudding";

            return recipe_name;
        }

        public string ReturnCategoryChocolate_pudding()
        {
            string recipe_category = "Desert";

            return recipe_category;
        }

        public string ReturnIngredientsChocolate_pudding()
        {
            string recipe_ingredients = "Bob5";

            return recipe_ingredients;
        }

        public string ReturnDescriptionChocolate_pudding()
        {
            string recipe_description = "Henk5";

            return recipe_description;
        }
        string recipe_name = "Chocolate pudding";
        string recipe_category = "Desert";
        string recipe_ingredients = "Bob5";
        string recipe_description = "Henk5";
    }
    class Strawberry_pudding : Recipe
    {
        public string ReturnNameStrawberry_pudding()
        {
            string recipe_name = "Strawberry pudding";

            return recipe_name;
        }

        public string ReturnCategoryStrawberry_pudding()
        {
            string recipe_category = "Desert";

            return recipe_category;
        }

        public string ReturnIngredientsStrawberry_pudding()
        {
            string recipe_ingredients = "Bob6";

            return recipe_ingredients;
        }

        public string ReturnDescriptionStrawberry_pudding()
        {
            string recipe_description = "Henk6";

            return recipe_description;
        }
    }
    class Vanilla_pudding : Recipe
    {
        public string ReturnNameVanilla_pudding()
        {
            string recipe_name = "Vanilla pudding";

            return recipe_name;
        }

        public string ReturnCategoryVanilla_pudding()
        {
            string recipe_category = "Desert";

            return recipe_category;
        }

        public string ReturnIngredientsVanilla_pudding()
        {
            string recipe_ingredients = "Bob7";

            return recipe_ingredients;
        }

        public string ReturnDescriptionVanilla_pudding()
        {
            string recipe_description = "Henk7";

            return recipe_description;
        }

        string recipe_name = "Vanilla pudding";
        string recipe_category = "Desert";
        string recipe_ingredients = "Bob7";
        string recipe_description = "Henk7";
    }
    class Tiramisu : Recipe
    {
        public string ReturnNameTiramisu()
        {
            string recipe_name = "Tiramisu";

            return recipe_name;
        }

        public string ReturnCategoryTiramisu()
        {
            string recipe_category = "Desert";

            return recipe_category;
        }

        public string ReturnIngredientsTiramisu()
        {
            string recipe_ingredients = "Bob8";

            return recipe_ingredients;
        }

        public string ReturnDescriptionTiramisu()
        {
            string recipe_description = "Henk8";

            return recipe_description;
        }

        string recipe_name = "Tiramisu";
        string recipe_category = "Desert";
        string recipe_ingredients = "Bob8";
        string recipe_description = "Henk8";
    }
    class Brownies : Recipe
    {
        public string ReturnNameBrownies()
        {
            string recipe_name = "Brownies";

            return recipe_name;
        }

        public string ReturnCategoryBrownies()
        {
            string recipe_category = "Snacks";

            return recipe_category;
        }

        public string ReturnIngredientsBrownies()
        {
            string recipe_ingredients = "Bob9";

            return recipe_ingredients;
        }

        public string ReturnDescriptionBrownies()
        {
            string recipe_description = "Henk9";

            return recipe_description;
        }
    }
    class Popcorn : Recipe
    {
        public string ReturnNamePopcorn()
        {
            string recipe_name = "Popcorn";

            return recipe_name;
        }

        public string ReturnCategoryPopcorn()
        {
            string recipe_category = "Snacks";

            return recipe_category;
        }

        public string ReturnIngredientsPopcorn()
        {
            string recipe_ingredients = "Bob10";

            return recipe_ingredients;
        }

        public string ReturnDescriptionPopcorn()
        {
            string recipe_description = "Henk10";

            return recipe_description;
        }
    }
    class Fudge : Recipe
    {
        public string ReturnNameFudge()
        {
            string recipe_name = "Fudge";

            return recipe_name;
        }

        public string ReturnCategoryFudge()
        {
            string recipe_category = "Snacks";

            return recipe_category;
        }

        public string ReturnIngredientsFudge()
        {
            string recipe_ingredients = "Bob11";

            return recipe_ingredients;
        }

        public string ReturnDescriptionFudge()
        {
            string recipe_description = "Henk11";

            return recipe_description;
        }
    }
    class Nachos : Recipe
    {
        public string ReturnNameNachos()
        {
            string recipe_name = "Nachos";

            return recipe_name;
        }

        public string ReturnCategoryNachos()
        {
            string recipe_category = "Snacks";

            return recipe_category;
        }

        public string ReturnIngredientsNachos()
        {
            string recipe_ingredients = "Bob12";

            return recipe_ingredients;
        }

        public string ReturnDescriptionNachos()
        {
            string recipe_description = "Henk12";

            return recipe_description;
        }
    }
    class Shepherds_pie : Recipe
    {
        public string ReturnNameShepherds_pie()
        {
            string recipe_name = "Shepherds pie";

            return recipe_name;
        }

        public string ReturnCategoryShepherds_pie()
        {
            string recipe_category = "Main dish";

            return recipe_category;
        }

        public string ReturnIngredientsShepherds_pie()
        {
            string recipe_ingredients = "Bob13";

            return recipe_ingredients;
        }

        public string ReturnDescriptionShepherds_pie()
        {
            string recipe_description = "Henk13";

            return recipe_description;
        }
    }
    class Hamburger : Recipe
    {
        public string ReturnNameHamburger()
        {
            string recipe_name = "Hamburger";

            return recipe_name;
        }

        public string ReturnCategoryHamburger()
        {
            string recipe_category = "Main dish";

            return recipe_category;
        }

        public string ReturnIngredientsHamburger()
        {
            string recipe_ingredients = "Bob14";

            return recipe_ingredients;
        }

        public string ReturnDescriptionHamburger()
        {
            string recipe_description = "Henk14";

            return recipe_description;
        }
    }
    class Chicken_soup : Recipe
    {
        public string ReturnNameChicken_soup()
        {
            string recipe_name = "Chicken soup";

            return recipe_name;
        }

        public string ReturnCategoryChicken_soup()
        {
            string recipe_category = "Main dish";

            return recipe_category;
        }

        public string ReturnIngredientsChicken_soup()
        {
            string recipe_ingredients = "Bob15";

            return recipe_ingredients;
        }

        public string ReturnDescriptionChicken_soup()
        {
            string recipe_description = "Henk15";

            return recipe_description;
        }
    }
    class Pasta_bolognese : Recipe
    {
        public string ReturnNamePasta_bolognese()
        {
            string recipe_name = "Pasta bolognese";

            return recipe_name;
        }

        public string ReturnCategoryPasta_bolognese()
        {
            string recipe_category = "Main dish";

            return recipe_category;
        }

        public string ReturnIngredientsPasta_bolognese()
        {
            string recipe_ingredients = "Bob16";

            return recipe_ingredients;
        }

        public string ReturnDescriptionPasta_bolognese()
        {
            string recipe_description = "Henk16";

            return recipe_description;
        }
    }
}