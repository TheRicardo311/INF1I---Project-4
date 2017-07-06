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
    public partial class PizzaMaker : ContentPage
    {

        public PizzaMaker(string selectedTopping, string ToppingName, string ToppingRecommendation)
        {
            InitializeComponent();

            // Set title of recipe
            this.Title = "PizzaBuilder";
            this.BackgroundColor = Color.Black;

            PlainPizza Pizza1 = new PlainPizza();

            Button clickbutton = new Button
            {
                Image = "add.png",

                BackgroundColor = Color.Transparent,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,

            };
            clickbutton.Clicked += Add_Pizza;

            Label _label = new Label
            {
                Text = "Category" + "\n\n" + Pizza1.Name() + "\n\n" + ToppingRecommendation,
                  
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.White
            };

            // Scroll view
            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = _label,
                Margin = new Thickness(20, 10, 20, 20)
            };
  
            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    clickbutton,
                    scrollView
                }
            };
        }

        private void Add_Pizza(object sender, EventArgs e)
        {
         
            Navigation.PushAsync(new PizzaMakerAdd());
        }
    }
}