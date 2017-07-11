using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WPFApp1
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
            this.Title = "Add your topping";
            this.BackgroundColor = Color.Black;

            InitializeComponent();

            //Display the toppings

            ListOfToppings.ItemsSource = _toppings;

            //Label _labelTopping = new Label
            //{
            //    Text = "\n\n" + selectedTopping,


            //    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            //    TextColor = Color.White
            //};



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
        private void TapDatTopping(object sender, SelectedItemChangedEventArgs e)
        {
            // Set selected item to string
            string selectedTopping = e.SelectedItem.ToString();

            //IPizza createNewPlainPizza = new Topping(new Mozzarella(new PlainPizza()));

            //if (selectedTopping == "Pepperoni")
            //{
            //    Topping createNewTopping = new Pepperoni(new PlainPizza());
            //}
              
            //Topping createNewTopping = new Topping(new PlainPizza());
            //    string ToppingName = createNewTopping.ExtractName();
            //    string ToppingRecommendation = createNewTopping.ExtractAanrader();
            

            NavigationPage newPage = new NavigationPage(new PizzaMaker(selectedTopping /*ToppingName*//*, ToppingRecommendation*/));
            Navigation.PushAsync(newPage);


            //Navigation.PushAsync(new PizzaMaker(selectedTopping, ToppingName, ToppingRecommendation));



            // Shows recipe details page
            //Navigation.PushAsync(new INSERTPAGEHERE(selectedTopping))
        }

    };

}
