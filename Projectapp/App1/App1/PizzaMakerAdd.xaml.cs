using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PizzaMakerAdd : ContentPage
    {

        //Creating a list of toppings, the dirty way
        private readonly List<string> _toppings = new List<string>
        {
            "Mozzarella", "Chicken", "Shoarma", "Pepperoni"
        };

        public PizzaMakerAdd()
        {
            InitializeComponent();

            //Display the toppings

            ListOfToppings.ItemsSource = _toppings;
        }

        private void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Sets the search keywords to string
            string keyword = MainSearchBar.Text;

            // Sets the search results in a list of string
            IEnumerable<string> searchResults = _toppings.Where(name => name.ToLower().Contains(keyword.ToLower()));

            // Update list with the search results
            ListOfToppings.ItemsSource = searchResults;
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
        /// When you tap something from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TapDatTopping(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new PizzaMaker());
        }

        private void Toppingselected(object sender, SelectedItemChangedEventArgs e)
        {
            // Set selected item to string
            string selectedTopping = e.SelectedItem.ToString();

            // Shows recipe details page
            //Navigation.PushAsync(new INSERTPAGEHERE(selectedTopping))
        }

    };

}
