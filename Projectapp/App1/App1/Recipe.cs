using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    interface Recipe
    {
        string ReturnName();
        string ReturnCategory();
        string ReturnIngredients();
        string ReturnDescription();
    }
    class French_toast : Recipe
    {
        //Type declaration
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        //Create and return recipe_name
        public string ReturnName()
        {
            string recipe_name = "French toast";

            return recipe_name;
        }
        
        public string ReturnCategory()
        {
            string recipe_category = "Breakfast";

            return recipe_category;
        }
        
        public string ReturnIngredients()
        {
            string recipe_ingredients = "- 1/4 teaspoon ground nutmeg" + "\n" + "- 1 teaspoon ground cinnamon" + "\n" + "- 2 tablespoons sugar" + "\n" + "- 4 tablespoons butter" + "\n" + "- 4 eggs" + "\n" + "- 1/4 cup milk" + "\n" + "- 1/2 teaspoon vanilla extract" + "- 8 slices challah, brioche, or white bread" + "- 1/2 cup maple syrup, warmed";

            return recipe_ingredients;
        }
        
        public string ReturnDescription()
        {
            string recipe_description = "In a small bowl, combine, cinnamon, nutmeg, and sugar and set aside briefly." + "\n" + "   In a 10-inch or 12-inch skillet, melt butter over medium heat." + "\n" + "Whisk together cinnamon mixture, eggs, milk, and vanilla and pour into a shallow container such as a pie plate." + "\n" + "Dip bread in egg mixture." + "\n" + "Fry slices until golden brown, then flip to cook the other side." + "\n" + "Serve with syrup.";

            return recipe_description;
        }
        
    }
    class Pancakes : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Pancakes";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Breakfast";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "- 1/2 cups all-purpose flour" + "\n" + "- 3 1/2 teaspoons baking powder" + "\n" + "- 1 teaspoon salt" + "\n" + "- 1 tablespoon white sugar" + "\n" + "- 1/4 cups milk" + "\n" + "- 1 egg" + "\n" + "- 3 tablespoons butter, melted";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "In a large bowl, sift together the flour, baking powder, salt and sugar." + "\n" + "Make a well in the center and pour in the milk, egg and melted butter; mix until smooth." + "\n" + "Heat a lightly oiled griddle or frying pan over medium high heat." + "\n" + "Pour or scoop the batter onto the griddle, using approximately 1/4 cup for each pancake." + "\n" + "Brown on both sides and serve hot.";

            return recipe_description;
        }
    }
    class Scrambled_eggs : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Scrambled eggs";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Breakfast";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "- 8 large free-range eggs" + "\n" + "- sea salt" + "\n" + "- freshly ground black pepper" + "\n" + "- a small knob of unsalted butter";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Eggs are delicate and will continue to cook even after you’ve taken them off the heat, so it’s really important to remove them just before they’re ready, so that they’ll be just right by the time you come to eat them." + "\n" + "Crack the eggs into a measuring jug." + "\n" + "Add a tiny pinch of salt and pepper, then use a fork to beat them together well." + "\n" + "Put a medium saucepan over a low heat and add the butter." + "\n" + "Leave it to melt slowly, then when it starts to bubble carefully pour in the eggs." + "\n" + "Stir slowly with a wooden spoon, or a spatula if you’ve got one, so you can get right to the edges of the pan." + "\n" + "Keep gently stirring until the eggs still look silky, slightly runny and slightly underdone, and then remove from the heat – the heat of the pan will continue to cook the eggs to perfection." + "\n" + "Serve with lightly buttered toast.";

            return recipe_description;
        }
    }
    class Croissants : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Croissants";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Breakfast";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "Bob4";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk4";

            return recipe_description;
        }
    }
    class Chocolate_pudding : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Chocolate pudding";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Desert";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "- 2/3 cup sugar" + "\n" + "- 1/4 cup Cocoa" + "\n" + "- 3 tablespoons cornstarch" + "\n" + "- 1/4 teaspoon salt" + "\n" + "- 2 1/4 cups milk" + "\n" + "- 2 tablespoons butter or margarine" + "\n" + "- 1 teaspoon vanilla extract" + "\n" + "- Whipped topping (optional)";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Stir together sugar, cocoa, cornstarch and salt in medium saucepan; gradually stir in milk." + "\n" + "Cook over medium heat, stirring constantly, until mixture boils; boil and stir 1 minute." + "\n" + "Remove from heat; stir in butter and vanilla. Pour into individual dessert dishes." + "\n" + "To avoid a skin from forming on top, press plastic wrap directly onto surface; serve warm or refrigerate at least 2 hours." + "\n" + "Garnish with whipped topping, if desired. 4 servings.";

            return recipe_description;
        }
    }
    class Strawberry_pudding : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Strawberry pudding";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Dessert";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "- 2 lbs strawberries" + "\n" + "- 1 cup sugar (to taste)" + "\n" + "- 1 quart water" + "- 1⁄3 cup cornstarch (if you like your pudding very stiff, use 1/2 cup)" + "- 1⁄2 teaspoon vanilla (optional)" + "\n" + "- 1⁄2 teaspoon finely grated lemon zest (optional)";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk6";

            return recipe_description;
        }
    }
    class Vanilla_pudding : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Vanilla pudding";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Dessert";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "- 1/3 cup sugar" + "\n" + "- 2 tablespoons cornstarch" + "\n" + "- 1/3 teaspoon salt" + "\n" + "- 2 cups milk" + "\n" + "- 2 large egg yolks, slightly beaten" + "\n" + "- 2 tablespoons butter or margarine, softened" + "\n" + "2 teaspoons vanilla";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk7";

            return recipe_description;
        }
    }
    class Tiramisu : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Tiramisu";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Dessert";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "Bob8";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk8";

            return recipe_description;
        }
    }
    class Brownies : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Brownies";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Snacks";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "Bob9";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk9";

            return recipe_description;
        }
    }
    class Popcorn : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Popcorn";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Snacks";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "Bob10";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk10";

            return recipe_description;
        }
    }
    class Fudge : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Fudge";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Snacks";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "Bob11";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk11";

            return recipe_description;
        }
    }
    class Nachos : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Nachos";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Snacks";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "Bob12";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk12";

            return recipe_description;
        }
    }
    class Shepherds_pie : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Shepherds pie";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Main dish";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "Bob13";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk13";

            return recipe_description;
        }
    }
    class Hamburger : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Hamburger";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Main dish";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "Bob14";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk14";

            return recipe_description;
        }
    }
    class Chicken_soup : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Chicken soup";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Main dish";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "Bob15";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk15";

            return recipe_description;
        }
    }
    class Pasta_bolognese : Recipe
    {
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;

        public string ReturnName()
        {
            string recipe_name = "Pasta bolognese";

            return recipe_name;
        }

        public string ReturnCategory()
        {
            string recipe_category = "Main dish";

            return recipe_category;
        }

        public string ReturnIngredients()
        {
            string recipe_ingredients = "Bob16";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Henk16";

            return recipe_description;
        }
    }
}