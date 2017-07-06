using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail : MasterDetailPage
    {
        // All the lists
        // List of Recipes
        private readonly List<string> _recipes = new List<string>
        {
            "French Toast", "Pancakes", "Scrambled eggs", "Croissants", "Chocolate pudding" , "Strawberry pudding", "Vanilla pudding", "Tiramisu", "Brownies", "Popcorn", "Fudge", "Nachos", "Sheperds Pie", "Hamburger", "Chicken soup", "Pasta bolognese"
        };

        // List of breakfast
        private readonly List<string> _breakfast = new List<string>
        {
            "French Toast", "Pancakes", "Scrambled eggs", "Croissants"
        };

        // List of dessert
        private readonly List<string> _dessert = new List<string>
        {
            "Chocolate pudding" , "Strawberry pudding", "Vanilla pudding", "Tiramisu"
        };

        // Snacks
        private readonly List<string> _snacks = new List<string>
        {
            "Brownies", "Popcorn", "Fudge", "Nachos"
        };

        // List of main dish
        private readonly List<string> _mainDish = new List<string>
        {
            "Sheperds Pie", "Hamburger", "Chicken soup", "Pasta bolognese"
        };


        private bool LoggedIn;
        public MasterDetail()
        {
            InitializeComponent();

            // Sets main page to the recipes page
            Detail = new NavigationPage(new MainPage(_recipes, "Recipes"));

            // Hides the menu
            IsPresented = false;
        }


        /// <summary>
        /// Click event that takes the user to recipes page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Recipes_Button(object sender, EventArgs e)
        {
            // Display the main page (recipes page)
            Detail = new NavigationPage(new MainPage(_recipes, "Recipes"));

            // Hides the menu
            IsPresented = false;
        }


        /// <summary>
        /// Click event that takes user to the bookmark page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bookmarks_Button(object sender, EventArgs e)
        {
            // Display the bookmark page
            Detail = new NavigationPage(new BookmarkPage());

            // Hides the menu
            IsPresented = false;
        }


        /// <summary>
        /// Click event that takes user to the suggestions page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Suggestions_Button(object sender, EventArgs e)
        {

            ConcreteRecipeFactory createNewrecipe = new ConcreteRecipeFactory();

            // Set random recipe as string
            string The_Ultimate_Recipe = new Suggestions().GetRandomRecipe();

            // Set values of recipes
            createNewrecipe.Create(The_Ultimate_Recipe);
            string recipeDescription = createNewrecipe.Create(The_Ultimate_Recipe).ReturnDescription();
            string recipeName = createNewrecipe.Create(The_Ultimate_Recipe).ReturnName();
            string recipeCategory = createNewrecipe.Create(The_Ultimate_Recipe).ReturnCategory();
            string recipeIngredients = createNewrecipe.Create(The_Ultimate_Recipe).ReturnIngredients();
            int recipeRating = createNewrecipe.Create(The_Ultimate_Recipe).ReturnRating();

            // Display the suggestions page
            Detail = new NavigationPage(new SuggestionPage(recipeName, recipeCategory, recipeIngredients, recipeDescription, recipeRating));

            // Hides the menu
            IsPresented = false;
        }

        /// <summary>
        /// Click event that takes user to the pizza maker page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pizza_Button(object sender, EventArgs e)
        {
            // Display the suggestions page
            Detail = new NavigationPage(new PizzaMaker(""));
            
            // Hides the menu
            IsPresented = false;
        }

        /// <summary>
        /// Click event that takes user to the log in page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogIn_Button(object sender, EventArgs e)
        {
            // Display the login page
            Detail = new NavigationPage(new LoginPage());

            // Hides the menu
            IsPresented = false;
        }


        private void BreakfastBtn(object sender, EventArgs e)
        {
            // Display the main page (recipes page)
            Detail = new NavigationPage(new MainPage(_breakfast, "Breakfast"));

            // Hides the menu
            IsPresented = false;
        }

        private void DessertBtn(object sender, EventArgs e)
        {
            // Display the main page (recipes page)
            Detail = new NavigationPage(new MainPage(_dessert, "Dessert"));

            // Hides the menu
            IsPresented = false;
        }
        private void SnacksBtn(object sender, EventArgs e)
        {
            // Display the main page (recipes page)
            Detail = new NavigationPage(new MainPage(_snacks, "Snacks"));

            // Hides the menu
            IsPresented = false;
        }
        private void Main_DishBtn(object sender, EventArgs e)
        {
            // Display the main page (recipes page)
            Detail = new NavigationPage(new MainPage(_mainDish, "Main Dish"));

            // Hides the menu
            IsPresented = false;
        }
    }
}