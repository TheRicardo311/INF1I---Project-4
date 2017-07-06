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

        public PizzaMaker()
        {
            InitializeComponent();

            // Set title of recipe
            this.Title = "PizzaBuilder";
            this.BackgroundColor = Color.Black;

            PlainPizza Pizza1 = new PlainPizza();

            Label _label = new Label
            {
                Text = "Catergory" + "\n\n" + Pizza1.Name(),


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
            /*this.Content = new StackLayout
            {
                Children =
                {
                    _image,
                    scrollView
                }
            };*/
        }

        private void Add_Pizza(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PizzaMakerAdd());
        }
    }
}