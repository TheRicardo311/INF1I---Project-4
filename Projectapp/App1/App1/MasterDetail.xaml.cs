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
        private bool LoggedIn;
        public MasterDetail()
        {
            InitializeComponent();

            // Sets main page to the recipes page
            Detail = new NavigationPage(new MainPage());

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
            Detail = new NavigationPage(new MainPage());

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
            Detail = new NavigationPage(new PizzaMaker("","",""));
            
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
    }
}