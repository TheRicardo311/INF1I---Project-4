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
    public partial class RecipeDetailsPage : ContentPage
    {
        public RecipeDetailsPage(string recipeName, string recipeCategory, string recipeIngredients, string recipeDescription)
        {
            InitializeComponent();

            // Set title of recipe
            this.Title = recipeName;
            this.BackgroundColor = Color.Black;



            // Set image
            Image _image = new Image
            {
                Source = recipeName + ".jpg"
            };

            // Set description as label
            Label _label = new Label
            {
                Text = "Catergory" + "\n\n" + recipeCategory + "\n\n\n" + 

                    "Ingredients" + "\n\n" + recipeIngredients + "\n\n\n" +

                    "Steps" + "\n\n" + recipeDescription + "\n", 


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
                    _image,
                    scrollView
                }
            };
        }
    }
}