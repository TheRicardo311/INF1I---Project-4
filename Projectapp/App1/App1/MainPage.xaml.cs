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
            "Pizza", "Appeltaart", "Peter", "Chicken Nuggets", "Lasagna" , "Appeltaart", "Peter", "Chicken Nuggets", "Lasagna"
            , "Appeltaart", "Peter", "Chicken Nuggets", "Lasagna", "Appeltaart", "Peter", "Chicken Nuggets", "Lasagna"
            , "Appeltaart", "Peter", "Chicken Nuggets", "Lasagna"
        };

        public MainPage()
        {
            InitializeComponent();

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
        /// Just a search button function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            // Sets the search keywords to string
            string keyword = MainSearchBar.Text;

            // Sets the search results in a list of string
            IEnumerable<string> searchResults = _recipes.Where(name => name.ToLower().Contains(keyword.ToLower()));

            // Update list with the search results
            ListOfRecipes.ItemsSource = searchResults;
        }
    }
}
