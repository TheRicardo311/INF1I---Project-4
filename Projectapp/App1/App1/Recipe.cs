using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    public interface Recipe
    {
        string ReturnName();
        string ReturnCategory();
        string ReturnIngredients();
        string ReturnDescription();
        string ReturnImage();
        int ReturnRating();
    }
    public class French_toast : Recipe
    {
        //Type declaration
        string recipe_name;
        string recipe_category;
        string recipe_ingredients;
        string recipe_description;
        string recipe_image;
        int recipe_rating;

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

        public string ReturnImage()
        {
            string recipe_image = "French Toast.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
        public string ReturnImage()
        {
            string recipe_image = "Pancakes.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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

        public string ReturnImage()
        {
            string recipe_image = "Scrambled eggs.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 500g French Type 55 flour or unbleached all-purpose flour / plain flour (extra for dusting)" + "\n" + "- 140g water" + "\n" + "- 140g whole milk (you can take it straight from the fridge)" + "\n" + "- 55g sugar" + "\n" + "- 40g soft unsalted butter" + "\n" + "- 11g instant yeast" + "\n" + "- 12g salt" + "\n" + "- 280g cold unsalted butter for laminating" + "\n" + "- 1 egg + 1 tsp water for the egg wash";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Day 1 – Make initial dough" + "\n" + "21.00 h – Knead for 3 minutes and store in fridge for 12 hours" + "\n\n" + "Day 2 – Laminate the dough" + "\n" + "09.00 h – Make butter slab and refrigerate till needed" + "\n" + "09.05 h – Roll dough disc into square" + "\n" + "09.10 h – Seal butter in dough" + "\n" + "09.15 h – Roll out to 20 cm x 60 cm and fold" + "\n" + "Refrigerate 30 minutes" + "\n" + "09.50 h – Rotate 90 degrees" + "\n" + "Roll out to 20 cm x 60 cm and fold" + "\n" + "Refrigerate 30 minutes" + "\n" + "10.25 h – Rotate 90 degrees" + "\n" + "Roll out to 20 cm x 60 cm and fold" + "\n" + "11.00 h – Refrigerate until day 3" + "\n\n" + "Day 3 – Dividing, Shaping, proofing and baking" + "\n" + "09.00 h – Roll out to 20 cm x 110 cm – part 1" + "\n" + "09.05 h – Often needed!Take 20 min.fridge time if length not in one go" + "\n" + "09.25 h – Roll out to 20 cm x 110 cm – part 2" + "\n" + "09.30 h – Divide and shape the croissants" + "\n" + "09.40 h – First coat of egg wash" + "\n" + "09.45 h – Proof to perfection(indication 2 hours)" + "\n" + "11.45 h – Second coat of egg wash" + "\n" + "11.50 h – Bake for 15 - 18 minutes" + "\n" + "12.10 h – Ready!";
            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Croissants.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_category = "Dessert";

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
        public string ReturnImage()
        {
            string recipe_image = "Chocolate pudding.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 2 lbs strawberries" + "\n" + "- 1 cup sugar (to taste)" + "\n" + "- 1 quart water" + "\n" + "- 1⁄3 cup cornstarch (if you like your pudding very stiff, use 1/2 cup)" + "\n" + "- 1⁄2 teaspoon vanilla (optional)" + "\n" + "- 1⁄2 teaspoon finely grated lemon zest (optional)";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Clean and rinse berries. If they are large cut in halves or quarters." + "\n" + "Bring water to a boil over medium heat." + "\n" + "Add sugar and strawberries and simmer until berries are tender, about 8 minutes. You will still have lumps of berries." + "\n" + "If you want a smooth consitency, break the fruit up by pushing the berries with the back of a spoon on the side of the pan." + "\n" + "Dissolve cornstach in a little water and add to fruit, stirring constantly." + "\n" + "Add vanilla or zest if desired(one or the other not both)." + "\n" + "Bring to rolling boil, stirring constantly. Continue stirring and allow pudding to boil a few minutes." + "\n" + "The pudding should no longer be cloudy and regain its shine and gloss." + "\n" + "Transfer to a bowl and place in the refrigerator until thouroughly cool. Depending on the bowl size and shape, this could take several hours." + "\n" + "If you are planning to substitute part of the sugar(would not suggest all) with baking Splenda, add the splenda to the bowl just before cooling." + "\n" + "Optional serving ideas: Top with whipped cream, Cool Whip or vanilla yogurt. Chocolate shavings or a dusting of cocoa are also nice.";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Strawberry pudding.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 1/3 cup sugar" + "\n" + "- 2 tablespoons cornstarch" + "\n" + "- 1/3 teaspoon salt" + "\n" + "- 2 cups milk" + "\n" + "- 2 large egg yolks, slightly beaten" + "\n" + "- 2 tablespoons butter or margarine, softened" + "\n" + "- 2 teaspoons vanilla";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "In 2-quart saucepan, mix sugar, cornstarch and salt." + "\n" + "Gradually stir in milk. Cook over medium heat, stirring constantly, until mixture thickens and boils." + "\n" + "Boil and stir 1 minute." + "\n" + "Gradually stir at least half of the hot mixture into egg yolks, then stir back into hot mixture in saucepan." + "\n" + "Boil and stir 1 minute; remove from heat." + "\n" + "Stir in butter and vanilla. Pour pudding into dessert dishes." + "\n" + "Cover and refrigerate about 1 hour or until chilled. Store covered in refrigerator.";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Vanilla pudding.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 6 large egg yolks" + "\n" + "- 1 cup sugar (201 gm)" + "- 1/4 cup mascarpone cheese - room temperature (284 gm)" + "\n" + "- 3/4 cup heavy whipping cream (420 ml)" + "\n" + "- 2 -7 oz packages Italian Lady fingers (Savoiardi)" + "\n" + "- 1 cup cold espresso or strong coffee (240 ml)" + "\n" + "- 1/2 cup coffee flavored Liqueur optional (120 ml)" + "\n" + "- 1 ounce cocoa for dusting (30 gm)";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Combine egg yolks and sugar in the top of a double boiler, over boiling water. Reduce heat to low, and cook for about 10 minutes, stirring constantly. This is your sabayon, remove from the heat and whip yolks until thick and lemon-colored." + "\n" + "Add Mascarpone to whipped yolks, beat until combined. In a separate bowl, whip cream to stiff peaks." + "\n" + "Gently fold the whipped cream in the mascarpone sabayon mixture and set aside. The mascarpone does not have to be at room temperature, but it will help it mix in easier if it is." + "\n" + "Take it out of the refrigerator as you gather ingredients to make the recipe." + "\n" + "Mix the cold espresso with the coffee liquor and dip the lady fingers into the mixture just long enough to get them wet, do not soak them! Arrange the lady fingers in the bottom of a 9 inch square baking dish(or container similarly sized)." + "\n" + "Spoon half the mascarpone cream filling over the lady fingers. Repeat process with another layer of lady fingers and cream." + "\n" + "Refrigerate 4 hours or overnight." + "\n" + "Dust with cocoa before serving.";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Tiramisu.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 1/2 cup butter" + "\n" + "- 1 cup white sugar" + "\n" + "- 2 eggs" + "\n" + "- 1 teaspoon vanilla extract" + "\n" + "- 1/3 cup unsweetened cocoa powder" + "\n" + "- 1/2 cup all-purpose flour" + "\n" + "- 1/4 teaspoon salt" + "\n" + "- 1/4 teaspoon baking powder" + "\n\n" + "Frosting:" + "\n" + "- 3 tablespoons butter, softened" + "\n" + "- 3 tablespoons unsweetened cocoa powder" + "\n" + "- 1 tablespoon honey" + "\n" + "- 1 teaspoon vanilla extract" + "\n" + "- 1 cup confectioners' sugar";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Preheat oven to 175 degrees C. Grease and flour an 8-inch square pan." + "\n" + "In a large saucepan, melt 1 / 2 cup butter. Remove from heat, and stir in sugar, eggs, and 1 teaspoon vanilla." + "\n" + "Beat in 1 / 3 cup cocoa, 1 / 2 cup flour, salt, and baking powder." + "\n" + "Spread batter into prepared pan. Bake in preheated oven for 25 to 30 minutes. Do not overcook." + "\n" + "To Make Frosting: Combine 3 tablespoons softened butter, 3 tablespoons cocoa, honey, 1 teaspoon vanilla extract, and 1 cup confectioners' sugar. Stir until smooth." + "\n" + "Frost brownies while they are still warm.";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Brownies.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 1/2 cup unpopped popcorn kernels" + "\n" + "- 1/2 cup butter" + "\n" + "- 1/4 cup sugar" + "\n" + "- 1 tablespoon water";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Pop the popcorn." + "\n" + "On the stove, melt the butter. Add sugar and bring to a boil. Boil about 2 minutes." + "\n" + "Add water and stir well. Quickly pour over popped corn, and toss to coat." + "\n" + "Chill the popcorn in the fridge for 15-20 minutes before serving.";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Popcorn.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 125g of butter" + "\n" + "- 390g tin of condensed milk" + "\n" + "- 2 tablespoons of golden syrup" + "- 220g of brown sugar" + "\n" + "- 200g of white chocolate - broken into pieces";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Break the white chocolate into pieces and chop. Set aside until needed." + "\n" + "Line the base and sides of a 28cm x 18cm slice tin with baking paper and set aside until needed." + "\n" + "Add the butter, golden syrup, condensed milk and brown sugar to a medium sized saucepan and cook over a low heat for approximately 10 minutes until the fudge mixture has started to thicken and the colour of the ingredients has turned a lovely golden brown." + "\n" + "Remove the saucepan from the heat and add the chopped white chocolate and quickly stir to combine." + "\n" + "Quickly pour the Caramel Fudge into your prepared tin and gently smooth the surface." + "\n" + "Place the Caramel Fudge into the fridge for 6 hours (preferably overnight) to set before cutting into small pieces to enjoy.";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Fudge.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 175g packet plain tortilla chips" + "\n" + "- 225g jar salsa" + "\n" + "- a few sliced spring onions" + "\n" + "- a good chunk of cheese" + "\n" + "- a pinch of crushed chilli kes" + "\n" + "- soured cream or guacamole (optional)";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Tip tortilla chips onto a baking tray, pour over salsa and scatter over a few sliced spring onions." + "\n" + "Grate over a good chunk of cheese(fontina is perfect, but cheddar will do)." + "\n" + "Add a pinch of crushed chilli flakes, then put under a hot grill for about 3 minutes to melt the cheese." + "\n" + "Serve with soured cream or guacamole(optional).";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Nachos.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 25g/1oz dripping" + "\n" + "- 1 large onion, finely chopped" + "\n" + "- 2 tbsp olive oil" + "\n" + "- 500g/1lb 2oz minced lamb" + "\n" + "- 1 tbsp plain flour" + "\n" + "- 2 bay leaves" + "\n" + "- 2 sprigs fresh thyme" + "\n" + "- 1 anchovy, finely chopped (optional)" + "\n" + "- 400g tin chopped tomatoes" + "\n" + "- 2 tsp Worcestershire sauce" + "- 450ml/16fl oz chicken, beef or lamb stock" + "\n" + "- salt and freshly ground black pepper" + "\n\n" + "For the mash:" + "\n" + "- 700g/1½lb potatoes, peeled and cut into halves or quarters" + "\n" + "- 55ml/2fl oz milk" + "\n" + "- 75g/3oz butter" + "\n" + "- 1 free-range egg yolk";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "In a large saucepan, heat the dripping. Add the onion and cook for 5 minutes. Meanwhile, in a large frying pan, heat a little olive oil and fry the mince, stirring, until browned all over." + "\n" + "While the meat is frying, break up any lumps with the back of the spoon. Stir the onions and add the flour(this helps to thicken the juices) and stir." + "\n" + "Mix well and add the bay leaves, thyme and the anchovy and stir." + "\n" + "Add the chopped tomatoes, stock (keep a little aside, for putting into the mince pan to de - glaze the pan) and Worcestershire sauce." + "\n" + "Add the cooked mince and then pour the stock mixture into empty mince pan, scraping off any bits of mince left in the pan." + "\n" + "Pour the remaining stock into the pan containing the sauce mixture. Bring the mixture to the boil, adding a pinch of salt and pepper and let it simmer for about 45 minutes, stirring regularly." + "\n" + "Preheat the oven to 200C / 180C Fan / Gas 6." + "\n" + "For the mash, boil the potatoes until tender(about 10 minutes)." + "\n" + "Drain, add the milk, butter and egg yolk, then mash until smooth. Season with salt and pepper." + "\n" + "Pour the meat into a 1.4 litre / 2½ pint ovenproof dish and spread the mash on top, smooth over and mark with a spatula." + "\n" + "Put the dish into the oven and cook until the surface is golden - brown.";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Shepherds pie.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 1/2 to 2 pounds ground beef (fat content of about 18 percent)" + "\n" + "- 4 ounces (1 cup) coarsely grated cheddar, pepper Jack, smoked Gouda, or other favorite cheese" + "\n" + "- Coarse sea salt and freshly ground black pepper" + "\n" + "- 4 hamburger buns or Kaiser rolls, cut sides lightly buttered" + "\n" + "- 4 Boston or Bibb lettuce leaves" + "\n" + "- 1 luscious red ripe tomato, thinly sliced" + "\n" + "- Condiments of choice: ketchup, mustard, mayonnaise, barbecue sauce, etc.";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Place the beef in a mixing bowl. Mix in the cheese with a wooden spoon." + "\n" + "Form the beef into four patties, each about one inch thick and slightly larger in diameter than the bun. Work with a light touch, handling the meat as little as possible." + "\n" + "Make a slight depression in the center — the patty should be slightly concave." + "\n" + "Arrange them on a plate lined with plastic wrap and cover with more plastic wrap." + "\n" + "Store in the refrigerator until ready to cook. (Tip: You can form the burgers up to six hours ahead.)" + "\n" + "Just before cooking, season the tops of the burgers with salt and pepper. (Note: You’ll need less salt than for a normal burger, as many cheeses are salty already.)" + "\n" + "Set up your grill for direct grilling and preheat to high. Ideally you’ll grill over a wood fire or over charcoal or gas with a handful of soaked hardwood chips." + "\n" + "Brush and oil the grill grate. Arrange the burgers on the grate." + "\n" + "Grill until the bottoms are browned, three to five minutes. Gently invert the burgers, using a spatula. Season the other side with salt and pepper." + "\n" + "Continue grilling the burgers until cooked to taste, seven to nine minutes in all for medium doneness — 160 degrees in the center when read on an instant - read meat thermometer inserted through the side of the burger." + "\n" + "Line the bottom bun halves with lettuce leaves. Place the burger on the lettuce and top with tomato and any desired condiments.";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Hamburger.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 1 whole, small-sized chicken, (roughly 1.2-1.4kg) feet and neck included (optional)" + "\n" + "- 2 large onions, finely chopped" + "\n" + "- 1/2 tablespoon (loosely packed) finely chopped sage" + "\n" + "- 1 teaspoon (loosely packed) finely chopped thyme" + "\n" + "- 1/2 tablespoon apple cider vinegar" + "\n" + "- 1 large carrot" + "\n" + "- 1 large stick of celery";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "Prepare the stock by placing the whole chicken(plus any additional bits: feet, necks, wingettes etc) in a large stock pot, with the herbs, vegetables, onions and vinegar." + "\n" + "Cover with cold water. Cook at a strong simmer, partially covered, for roughly 90 minutes. The chicken will be ready when the meat starts to separate easily from the bone." +"\n" + "Remove the carrots and celery from the cooking pot and discard. Drain liquid from the meat and set aside(you can keep the onions and herbs in the stock)." + "\n" + "Separate the meat from the bone and set aside 2 cups of shredded chicken for your soup (any leftovers can be used in chicken sandwiches)." + "\n" + "Measure out your stock – you should have roughly two litres. If you have more, you can reduce the liquid." + "\n" + "If you have less, just add additional water. Now you are ready to make your soup.";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Chicken soup.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
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
            string recipe_ingredients = "- 2 tbsp olive oil" + "\n" + "- 1 onion, finely diced" + "\n" + "- 500g minced beef" + "\n" + "- 1 clove garlic, crushed" + "\n" + "- 1/4 cup tomato paste" + "\n" + "- 1 tsp oregano" + "\n" + "- 1 cup red wine" + "\n" + "- 1 tin tomato soup" + "\n" + "- 2 tbsp sweet chilli sauce" + "\n" + "- 2 tbsp tomato sauce" + "\n" + "- 1 cup chicken stock" + "\n" + "- salt and pepper";

            return recipe_ingredients;
        }

        public string ReturnDescription()
        {
            string recipe_description = "In a pan, heat the oil and brown the minced beef, onion and garlic. Add the tomato paste to the pan and cook for 2 minutes." + "\n" + "Stir in the tomato sauce, sweet chilli, red wine, chicken stock, tomato soup and oregano." + "\n" + "Bring to the boil and simmer for 30 minutes." + "\n" + "Season with salt and pepper." + "\n" + "Serve over hot pasta.";

            return recipe_description;
        }
        public string ReturnImage()
        {
            string recipe_image = "Pasta bolognese.jpg";

            return recipe_image;
        }

        public int ReturnRating()
        {
            int recipe_rating = 0;

            return recipe_rating;
        }
    }
}