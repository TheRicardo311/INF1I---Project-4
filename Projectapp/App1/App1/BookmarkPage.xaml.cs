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
    public partial class BookmarkPage : ContentPage
    {
        List<string> _bookmarks = new List<string> { "" };
        public BookmarkPage()
        {
            InitializeComponent();

            // Display bookmark recipes in listview
            ListOfBookmarks.ItemsSource = _bookmarks;
        }

        /// <summary>
        /// Just a search button function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookmarkSearchButtonPressed(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Update list real time while searching
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Sets the search keywords to string
            string keyword = BookmarkSearch.Text;

            // Sets the search results in a list of string
            IEnumerable<string> searchResults = _bookmarks.Where(name => name.ToLower().Contains(keyword.ToLower()));

            // Update list with the search results
            ListOfBookmarks.ItemsSource = searchResults;
        }

        /// <summary>
        /// Select item from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBookmark(object sender, SelectedItemChangedEventArgs e)
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