using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WPFApp1
{
    class DataBaseYo
    {
        private MySqlConnection connection;
        private MySqlCommand cmd;
        private MySqlDataReader mdr;
        private string server;
        private string database;
        private string userid;
        private string password;


        //Constructor
        public DataBaseYo()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "Project4";
            userid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "Database=" +
                database + ";" + "User ID=" + userid + ";" + "Password=" + password + ";";

            connection = new MySqlConnection(connectionString);


            string sqlQuery = @"DROP TABLE IF EXISTS bookmarks;
                                DROP TABLE IF EXISTS recipe;

                                        CREATE TABLE recipe
                                        (
                                            recipe_name varchar(32),
                                            ingredients varchar(6666),
                                            description varchar(6666),
        				                    category varchar(25)
                                        );

                                        CREATE TABLE bookmarks(
	                                        user_id int,
	                                        user_name varchar(33),
	                                        recipe_name varchar(6666)
                                        );

                                        INSERT INTO recipe
                                        VALUES
('French toast', '1/4 teaspoon ground nutmeg, 1 teaspoon ground cinnamon, 2 tablespoons sugar, 4 tablespoons butter, 4 eggs, 1/4 cup milk, 1/2 teaspoon vanilla extract, 8 slices challah, brioche, or white bread, 1/2 cup maple syrup', 'In a small bowl, combine, cinnamon, nutmeg, and sugar and set aside briefly. In a 10-inch or 12-inch skillet, melt butter over medium heat. Whisk together cinnamon mixture, eggs, milk, and vanilla and pour into a shallow container such as a pie plate. Dip bread in egg mixture. Fry slices until golden brown, then flip to cook the other side. Serve with syrup.', 'breakfast'),
('Pancakes', '1 1/2 cups all-purpose flour, 3 1/2 teaspoons baking powder, 1 teaspoon salt, 1 tablespoon white sugar, 1 1/4 cups milk, 1 egg, 3 tablespoons butter', 'In a large bowl, sift together the flour, baking powder, salt and sugar. Make a well in the center and pour in the milk, egg and melted butter; mix until smooth. Heat a lightly oiled griddle or frying pan over medium high heat. Pour or scoop the batter onto the griddle, using approximately 1/4 cup for each pancake. Brown on both sides and serve hot..', 'breakfast'),
('Scrambled eggs', '8 large free-range eggs, sea salt, freshly ground black pepper, a small knob of unsalted butter', 'Crack the eggs into a measuring jug. Add a tiny pinch of salt and pepper, then use a fork to beat them together well. Put a medium saucepan over a low heat and add the butter. Leave it to melt slowly, then when it starts to bubble carefully pour in the eggs. Stir slowly with a wooden spoon, or a spatula if you’ve got one, so you can get right to the edges of the pan. Keep gently stirring until the eggs still look silky, slightly runny and slightly underdone, and then remove from the heat – the heat of the pan will continue to cook the eggs to perfection. Serve with lightly buttered toast.', 'breakfast'),
('Croissants', '500 g French Type 55 flour or unbleached all-purpose flour / plain flour (extra for dusting), 140 g water, 140 g whole milk (you can take it straight from the fridge), 55 g sugar, 40 g soft unsalted butter, 11 g instant yeast, 12 g salt, 280 g cold unsalted butter for laminating ', 'Maak een kuiltje in de bloem, giet het water erin en los de gist hierin op. Voeg de suiker toe. Strooi het zout in de bloem. Houd 50 gram boter achter. Voeg de rest van de boter toe. Meng beetje bij beetje de bloem erdoor en kneed tot een soepel deeg. Bestuif het aanrecht met een beetje bloem en rol het deeg uit tot circa 1 cm dikte. Dek het deeg af met plasticfolie en leg circa 40 minuten in de koelkast. Haal het deeg uit de koelkast en bestuif met bloem. Wrijf de achtergehouden boter uit over tweederde van de oppervlakte van het deeg. Houd de randen vrij. Vouw het deeg in 3 delen, start hierbij met het niet-beboterde deel. Rol opnieuw uit tot 2,5 cm en vouw nogmaals in 3 delen. Verpak het deeg in bakpapier en leg 40 minuten in de koelkast. Herhaal het uitrollen nog tweemaal en rol het op het laatst uit tot 1,5 cm dik. Snijd driehoekjes uit het deeg en rol op tot een croissant. Leg de croissants op een met bakpapier beklede bakplaat, dek af met een theedoek of ingevet plasticfolie en laat circa 90 minuten rijzen. Verwarm de oven voor op 230 °C bak de croissantjes in circa 25 minuten goudbruin en krokant.', 'breakfast'),
('Chocolate pudding', '2/3 cup sugar, 1/4 cup HERSHEYS Cocoa, 3 tablespoons cornstarch, 1/4 teaspoon salt, 2-1/4 cups milk, 2 tablespoons butter or margarine, 1 teaspoon vanilla extract, Whipped topping (optional)', 'Stir together sugar, cocoa, cornstarch and salt in medium saucepan, gradually stir in milk. Cook over medium heat, stirring constantly, until mixture boils, boil and stir 1 minute. Remove from heat, stir in butter and vanilla. Pour into individual dessert dishes. To avoid a skin from forming on top, press plastic wrap directly onto surface, serve warm or refrigerate at least 2 hours. Garnish with whipped topping, if desired. 4 servings.', 'Desert'),
('Strawberry pudding', '2 lbs strawberries, 1 cup sugar (to taste), 1 quart water, 1⁄3 cup cornstarch (if you like your pudding very stiff, use 1/2 cup), 1⁄2 teaspoon vanilla (optional), 1⁄2 teaspoon finely grated lemon zest (optional)', 'Clean and rinse berries. If they are large cut in halves or quarters. Bring water to a boil over medium heat. Add sugar and strawberries and simmer until berries are tender, about 8 minutes. You will still have lumps of berries. If you want a smooth consitency, break the fruit up by pushing the berries with the back of a spoon on the side of the pan. Dissolve cornstach in a little water and add to fruit, stirring constantly. Add vanilla or zest if desired (one or the other not both). Bring to rolling boil, stirring constantly. Continue stirring and allow pudding to boil a few minutes. The pudding should no longer be cloudy and regain its shine and gloss. Transfer to a bowl and place in the refrigerator until thouroughly cool. Depending on the bowl size and shape, this could take several hours. If you are planning to substitute part of the sugar (would not suggest all) with baking Splenda, add the splenda to the bowl just before cooling. Optional serving ideas: Top with whipped cream, Cool Whip or vanilla yogurt. Chocolate shavings or a dusting of cocoa are also nice ', 'Desert'),
('Vanilla Pudding', '⅓ cup sugar, 2 tablespoons cornstarch, ⅛ teaspoon salt, 2 cups milk, 2 large egg yolks, slightly beaten, 2 tablespoons butter or margarine, softened, 2 teaspoons vanilla', 'In 2-quart saucepan, mix sugar, cornstarch and salt. Gradually stir in milk. Cook over medium heat, stirring constantly, until mixture thickens and boils. Boil and stir 1 minute. Gradually stir at least half of the hot mixture into egg yolks, then stir back into hot mixture in saucepan. Boil and stir 1 minute; remove from heat. Stir in butter and vanilla. Pour pudding into dessert dishes. Cover and refrigerate about 1 hour or until chilled. Store covered in refrigerator.', 'Desert'),
('Tiramisu', '6 large egg yolks, 1 cup sugar (201 gm), 1 1/4 cup mascarpone cheese - room temperature (284 gm), 1 3/4 cup heavy whipping cream (420 ml), 2 -7 oz packages Italian Lady fingers (Savoiardi), 1 cup cold espresso or strong coffee (240 ml), 1/2 cup coffee flavored Liqueur optional (120 ml), 1 ounce cocoa for dusting (30 gm)', 'Combine egg yolks and sugar in the top of a double boiler, over boiling water. Reduce heat to low, and cook for about 10 minutes, stirring constantly. This is your sabayon, remove from the heat and whip yolks until thick and lemon-colored. Add Mascarpone to whipped yolks, beat until combined. In a separate bowl, whip cream to stiff peaks. Gently fold the whipped cream in the mascarpone sabayon mixture and set aside. The mascarpone does not have to be at room temperature, but it will help it mix in easier if it is.  Take it out of the refrigerator as you gather ingredients to make the recipe. Mix the cold espresso with the coffee liquor and dip the lady fingers into the mixture just long enough to get them wet, do not soak them! Arrange the lady fingers in the bottom of a 9 inch square baking dish (or container similarly sized) Spoon half the mascarpone cream filling over the lady fingers. Repeat process with another layer of lady fingers and cream. Refrigerate 4 hours or overnight. Dust with cocoa before serving ', 'Desert'),
('Brownies', '1/2 cup butter, 1 cup white sugar, 2 eggs, 1 teaspoon vanilla extract, 1/3 cup unsweetened cocoa powder, 1/2 cup all-purpose flour, 1/4 teaspoon salt, 1/4 teaspoon baking powder, Frosting, 3 tablespoons butter, softened, 3 tablespoons unsweetened cocoa powder, 1 tablespoon honey, 1 teaspoon vanilla extract, 1 cup confectioners sugar', 'Preheat oven to 350 degrees F (175 degrees C). Grease and flour an 8-inch square pan. In a large saucepan, melt 1/2 cup butter. Remove from heat, and stir in sugar, eggs, and 1 teaspoon vanilla. Beat in 1/3 cup cocoa, 1/2 cup flour, salt, and baking powder. Spread batter into prepared pan. Bake in preheated oven for 25 to 30 minutes. Do not overcook. To Make Frosting: Combine 3 tablespoons softened butter, 3 tablespoons cocoa, honey, 1 teaspoon vanilla extract, and 1 cup confectioners sugar. Stir until smooth. Frost brownies while they are still warm.', 'Snacks'),
('Nachos', '175g packet plain tortilla, chips, 225g jar salsa, a few sliced spring onions, a good chunk of cheese, a pinch of crushed chilli, flakes, soured cream or guacamole (optional)', 'Tip tortilla chips on to a baking tray, pour over salsa and scatter over a few sliced spring onions. Grate over a good chunk of cheese (fontina is perfect, but cheddar will do). Add a pinch of crushed chilli flakes, then put under a hot grill for about 3 minutes to melt the cheese. Serve with soured cream or guacamole (optional). ', 'Snacks'),
('Fudge', '125g of butter, 390g tin of condensed milk, 2 tablespoons of golden syrup, 220g of brown sugar, 200g of white chocolate - broken into pieces', 'Break the white chocolate into pieces and chop. Set aside until needed. Line the base and sides of a 28cm x 18cm slice tin with baking paper and set aside until needed. Add the butter, golden syrup, condensed milk and brown sugar to a medium sized saucepan and cook over a low heat for approximately 10 minutes until the fudge mixture has started to thicken and the colour of the ingredients has turned a lovely golden brown. Remove the saucepan from the heat and add the chopped white chocolate and quickly stir to combine. Quickly pour the Caramel Fudge into your prepared tin and gently smooth the surface. Place the Caramel Fudge into the fridge for 6 hours (preferably overnight) to set before cutting into small pieces to enjoy.', 'Snacks'),
('Popcorn', '1/2 cup unpopped popcorn kernels, 1/2 cup butter, 1/4 cup sugar, 1 tablespoon water', 'Pop the popcorn. (I use an air popper, but any method is fine.). On the stove, melt the butter. Add sugar and bring to a boil. Boil about 2 minutes. Add water and stir well. Quickly pour over popped corn, and toss to coat. Chill the popcorn in the fridge for 15-20 minutes before serving.', 'Snacks'),
('Spaghetti bolognese', 'Spaghetti, bolognese saus, tomatos, sweet chillie, red wine, chicken stock, oregano','In a pan, heat the oil and brown the minced beef, onion and garlic. Add the tomato paste to the pan and cook for 2 minutes. Stir in the tomato sauce, sweet chilli, red wine, chicken stock, tomato soup and oregano. Bring to the boil and simmer for 30 minutes. Season with salt and pepper. Serve over hot spaghetti.', 'Main dish'),
('Chicken soup', '2 tbsp olive oil, 1 onion, finely diced, 500g minced beef, 1 clove garlic, crushed, 1/4 cup tomato paste, 1 tsp oregano, 1 cup red wine, 1 tin tomato soup, 2 tbsp sweet chilli sauce, 2 tbsp tomato sauce, 1 cup chicken stock, salt and pepper, For the stock: 1 whole, small-sized chicken, (roughly 1.2-1.4kg) feet and neck included (optional), 2 large onions, finely chopped, 1/2 tablespoon (loosely packed) finely chopped sage, 1 teaspoon (loosely packed) finely chopped thyme, 1/2 tablespoon apple cider vinegar, 1 large carrot, 1 large stick of celery, For the soup: 2 litres of chicken stock (extracted from stock-making recipe), 2 cups shredded chicken meat (extracted from stock making recipe), 1 1/2 cups finely chopped celery, 1 1/2 cups finely chopped carrots, 2 - 5 cloves garlic minced garlic (a garlic crusher works a treat), 1 tablespoon finely grated ginger, 1 teaspoon finely grated turmeric, 1 cup (loosely packed) finely chopped parsley, 1/2 cup (loosely packed) finely chopped fresh coriander, 1 can green lentils, drained and rinsed (optional), generous seasoning of sea salt', 'For stock: Prepare the stock by placing the whole chicken (plus any additional bits: feet, necks, wingettes etc) in a large stock pot, with the herbs, vegetables, onions and vinegar. Cover with cold water. Cook at a strong simmer, partially covered, for roughly 90 minutes. The chicken will be ready when the meat starts to separate easily from the bone. Remove the carrots and celery from the cooking pot and discard. Drain liquid from the meat and set aside (you can keep the onions and herbs in the stock). Separate the meat from the bone and set aside 2 cups of shredded chicken for your soup (any leftovers can be used in chicken sandwiches). Measure out your stock – you should have roughly two litres. If you have more, you can reduce the liquid. If you have less, just add additional water. Now you are ready to make your soup. For soup: Add the finely chopped celery, carrots and a dash of olive oil to the bottom of a cooking pot on a medium heat. Let it simmer for 3-5 minutes or until the vegetables soften. Add your stock to the cooking pot, together with the chicken meat. Bring to a gentle simmer and cook for 5-10 minutes or until vegetables soften further. Add the garlic and spices and simmer for another minute or so. Season generously with sea salt. Remove the pot from the heat and stir through the coriander and parsley. Serve immediately.', 'Main Dish'),
('Hamburger', '1-1/2 to 2 pounds ground beef (fat content of about 18 percent), 4 ounces (1 cup) coarsely grated cheddar, pepper Jack, smoked Gouda, or other favorite cheese, Coarse sea salt and freshly ground black pepper, 4 hamburger buns or Kaiser rolls, cut sides lightly buttered, 4 Boston or Bibb lettuce leaves, 1 luscious red ripe tomato, thinly sliced, Condiments of choice: ketchup, mustard, mayonnaise, barbecue sauce, etc.', 'Place the beef in a mixing bowl. Mix in the cheese with a wooden spoon. Form the beef into four patties, each about one inch thick and slightly larger in diameter than the bun. Work with a light touch, handling the meat as little as possible. Make a slight depression in the center — the patty should be slightly concave. Arrange them on a plate lined with plastic wrap and cover with more plastic wrap. Store in the refrigerator until ready to cook. (Tip: You can form the burgers up to six hours ahead.) Just before cooking, season the tops of the burgers with salt and pepper. (Note: You’ll need less salt than for a normal burger, as many cheeses are salty already.) Set up your grill for direct grilling and preheat to high. Ideally you’ll grill over a wood fire or over charcoal or gas with a handful of soaked hardwood chips. Brush and oil the grill grate. Arrange the burgers on the grate. Grill until the bottoms are browned, three to five minutes. Gently invert the burgers, using a spatula. Season the other side with salt and pepper. Continue grilling the burgers until cooked to taste, seven to nine minutes in all for medium doneness — 160 degrees in the center when read on an instant-read meat thermometer inserted through the side of the burger. Line the bottom bun halves with lettuce leaves. Place the burger on the lettuce and top with tomato and any desired condiments.', 'Main Dish'),
('Sheperd’s pie', '25g/1oz dripping, 1 large onion, finely chopped, 2 tbsp olive oil, 500g/1lb 2oz minced lamb, 1 tbsp plain flour, 2 bay leaves, 2 sprigs fresh thyme, 1 anchovy, finely chopped (optional), 1 x 400g tin chopped tomatoes, 2 tsp Worcestershire sauce, 450ml/16fl oz chicken, beef or lamb stock, salt and freshly ground black pepper, For the mash, 700g/1½lb potatoes, peeled and cut into halves or quarters, 55ml/2fl oz milk, 75g/3oz butter, 1 free-range egg yolk', 'In a large saucepan, heat the dripping. Add the onion and cook for 5 minutes. Meanwhile, in a large frying pan, heat a little olive oil and fry the mince, stirring, until browned all over. While the meat is frying, break up any lumps with the back of the spoon. Stir the onions and add the flour (this helps to thicken the juices) and stir. Mix well and add the bay leaves, thyme and the anchovy and stir. Add the chopped tomatoes, stock (keep a little aside, for putting into the mince pan to de-glaze the pan) and Worcestershire sauce. Add the cooked mince and then pour the stock mixture into empty mince pan, scraping off any bits of mince left in the pan. Pour the remaining stock into the pan containing the sauce mixture. Bring the mixture to the boil, adding a pinch of salt and pepper and let it simmer for about 45 minutes, stirring regularly. Preheat the oven to 200C/180C Fan/Gas 6. For the mash, boil the potatoes until tender (about 10 minutes). Drain, add the milk, butter and egg yolk, then mash until smooth. Season with salt and pepper. Pour the meat into a 1.4 litre/2½ pint ovenproof dish and spread the mash on top, smooth over and mark with a spatula. Put the dish into the oven and cook until the surface is golden-brown.', 'Main Dish');

                                        INSERT INTO bookmarks
                                        VALUES (1, 'Henk', 'French Toast'),
                                                (2, 'Ricardo', 'Pancakes')";

            this.dbCommand(sqlQuery);
        }

        //Open the connection to the database
        private void OpenConnection()
        {
            connection.Open();
        }

        //Close the connection to the database
        private void CloseConnection()
        {
            connection.Close();
        }

        //Insert user statement
        public void InsertUser(int user_id, string user_name, string user_pass)
        {
            string query = "INSERT INTO tableinfo (user_id, 4) VALUES('Bob', 'Henkmeister')";

            //Open connection
            this.OpenConnection();

            //Create command for the query
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //Close connection
            this.CloseConnection();
        }

        //Insert user statement
        public void InsertLikes(string user_id, int recept_id)
        {
            string query = "INSERT INTO tableinfo (user_id, 4) VALUES('Bob', 'Henkmeister')";

            //Open connection
            this.OpenConnection();

            //Create command for the query
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //Close connection
            this.CloseConnection();

        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            this.OpenConnection();

            //Create the command
            MySqlCommand cmd = new MySqlCommand();

            //Assign the query using CommandText
            cmd.CommandText = query;

            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            //Close connection
            this.CloseConnection();
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            //Open connection
            this.OpenConnection();

            //Create the command
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute query
            cmd.ExecuteNonQuery();

            //Close connection
            this.CloseConnection();
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            this.OpenConnection();

            //Create command
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                list[0].Add(dataReader["id"] + "");
                list[1].Add(dataReader["name"] + "");
                list[2].Add(dataReader["age"] + "");
            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return list;



        }
        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            this.OpenConnection();

            //Create Mysql Command
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //ExecuteScalar will return one value
            Count = int.Parse(cmd.ExecuteScalar() + "");

            //close Connection
            this.CloseConnection();

            return Count;
        }

        // Database command
        public void dbCommand(string sqlQuery)
        {
            this.OpenConnection();
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            this.CloseConnection();
        }

        public bool getUsername(string _userName)
        {
            string output;

            this.OpenConnection();

            string sqlQuery = @"SELECT * FROM bookmarks WHERE user_name="+ "'" + _userName + "'";
            cmd = new MySqlCommand(sqlQuery, connection);

            mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                output = mdr.GetString("user_name");
                if (output == _userName)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            this.CloseConnection();

            return false;
        }
    }
}
