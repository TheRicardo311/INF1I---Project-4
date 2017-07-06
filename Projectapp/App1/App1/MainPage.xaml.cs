using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        // List of Recipes
        private readonly List<string> _recipes = new List<string>
        {
            "French Toast", "Pancakes", "Scrambled eggs", "Croissants", "Chocolate pudding" , "Strawberry pudding", "Vanilla pudding", "Tiramisu", "Brownies", "Popcorn", "Fudge", "Nachos", "Sheperds Pie", "Hamburger", "Chicken soup", "Pasta bolognese"
        };

        public MainPage()
        {
            InitializeComponent();

            // Display the recipes
            ListOfRecipes.ItemsSource = _recipes;
        }

        /// <summary>
        /// When filter button clicked, filter page pops up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filter_Button(object sender, EventArgs e)
        {
            // Shows the filter page
            Navigation.PushAsync(new FilterPage());
        }

        /// <summary>
        /// Update list real time while typing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Sets the search keywords to string
            string keyword = MainSearchBar.Text;

            // Sets the search results in a list of string
            IEnumerable<string> searchResults = _recipes.Where(name => name.ToLower().Contains(keyword.ToLower()));

            // Update list with the search results
            ListOfRecipes.ItemsSource = searchResults;
        }

        /// <summary>
        /// Just a search button function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Select item from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecipeSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Set selected item to string
            string selectedRecipe = e.SelectedItem.ToString();

            ConcreteRecipeFactory createNewrecipe = new ConcreteRecipeFactory();
            createNewrecipe.Create(selectedRecipe);
            string recipeDescription = createNewrecipe.Create(selectedRecipe).ReturnDescription();
            string recipeName = createNewrecipe.Create(selectedRecipe).ReturnName();
            string recipeCategory = createNewrecipe.Create(selectedRecipe).ReturnCategory();
            string recipeIngredients = createNewrecipe.Create(selectedRecipe).ReturnIngredients();
            int recipeRating = createNewrecipe.Create(selectedRecipe).ReturnRating();

            // Shows recipe details page
            Navigation.PushAsync(new RecipeDetailsPage(recipeName, recipeCategory, recipeIngredients, recipeDescription, recipeRating));
        }
    }
}
