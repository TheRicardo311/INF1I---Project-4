using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.Droid;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1.Droid
{
    //Decorator for the toppings of the pizza categorie
    public abstract class Topping : IPizza
    {
        //New temporary pizza
        public IPizza tempPizza;
        
        public Topping (IPizza newPizza)
        {
            this.tempPizza = newPizza;
        }

        //Uses the getDescription method from the IPizza interface
        public string getDescription()
        {
            return tempPizza.getDescription();
            
        }

    }

    public class Mozzarella : Topping
    {
        public Mozzarella(IPizza newPizza) : base(newPizza) 
        {
            
            string getDescription()
            {
                return getDescription() + "Adding a Mozzarella topping";

            }
        }
    }
    
    public class Pepperoni : Topping
    {

        public Pepperoni(IPizza newPizza) : base(newPizza)
        {
            string getDescription()
            {
                return getDescription() + "Adding a Pepperoni topping";

            }
        }
    }
    
    public class Chicken : Topping
    {
        public Chicken(IPizza newPizza) : base(newPizza)
        {
            string getDescription()
            {
                return getDescription() + "Adding a Chicken topping";

            }
        }
    }
    public class Shoarma : Topping
    {
        public Shoarma(IPizza newPizza) : base(newPizza)
        {
            string getDescription()
            {
                return getDescription() + "Adding a Shoarma topping";

            }
        }
    }
}
//Meat Pizza Toppings
//Sausage, caramelized onions and fennel
//Pepperoni, tomatoes, mushrooms and onion
//Pepperoni, sausage, green pepper, onion and mushroom
//BBQ sauce, topped with grilled chicken and cheddar cheese
//Thousand Island dressing, topped with sauerkraut, corned beef or pastrami and Swiss cheese
//Corn and spicy Italian salami
//Gorgonzola, bacon, apples and red onion
//Roasted red peppers, chorizo and feta
//Sausage and pineapple
//Buffalo chicken and blue cheese
//Gorgonzola, artichoke hearts, prosciutto, red onion and tomato
//Figs, prosciutto and caramelized onions
//Grilled chicken, avocado and cherry tomatoes
//Bacon and avocado
//Spinach, caramelized onion and bacon
//Roasted Brussels sprouts and bacon or pancetta
//Seafood Pizza Toppings
//Anchovies, tomato, ricotta and mustard greens
//Mozzarella and canned smoked oysters
//Pesto, butterflied prawns, mushrooms and Parmesan
//Sardines, red onions and black olives
//Alfredo sauce, shrimp and tomatoes
//Canned tuna fish, red onions and black olives
//Mascarpone or cream cheese, topped with smoked salmon, capers and red onion
//Cajun-seasoned shrimp, red bell peppers, red onions and garlic
//Vegetarian Pizza Toppings
//Pesto with white beans, tomato, arugula and Parmesan
//Pesto with artichoke hearts, feta, sun-dried tomatoes and Parmesan
//Alfredo sauce, spinach, mushrooms, red bell peppers and Asiago
//Garlic olive oil with Grúyere, caramelized onions and baked butternut squash
//Goat cheese with arugula and red onion
//Jalapeño peppers and pineapple
//Fried eggplant slices and black olives
//Sauceless with garlic, lime, avocado and fried green tomatoes
//Spinach, artichoke hearts, garlic and red onion
//Brie and artichokes
//Olive oil with paper-thin sliced potatoes, sage and Fontina
//Figs, artichoke hearts, Gorgonzola and balsamic vinegar
//Alfredo sauce with artichoke hearts, garlic and jalapeños
//Caramelized fennel, onion, olives and Fontina
//Goat cheese with red grapes and rosemary
//Roasted peppers, capers and ricotta
//Portobello mushrooms and kale
//Sauceless with Fontina, kale, sweet potato and red onion
//Caramelized onion, kale and green apples
//Brie and caramelized onion
//Burrata, arugula and paper-thin sliced lemons
//Brussels sprouts, red onion and ricotta
//Goat cheese with roasted beets and beet greens or arugula