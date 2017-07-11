using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WPFApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeDetailsPage : ContentPage
    {
        int rating;
        public RecipeDetailsPage(string recipeName, string recipeCategory, string recipeIngredients, string recipeDescription, int recipeRating)
        {
            InitializeComponent();

            rating = recipeRating;

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
                Text = "Category" + "\n\n" + recipeCategory + "\n\n\n" + 

                    "Ingredients" + "\n\n" + recipeIngredients + "\n\n\n" +

                    "Steps" + "\n\n" + recipeDescription + "\n\n\n\n" + 
                    "You liked this recipe " + rating + " times." + "\n",

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

            // Set layout
            var sl = new StackLayout{};
            sl.Children.Add(scrollView);

            //Like bar button
            ToolbarItems.Add(new ToolbarItem("Like", "like1.png", () =>
            {
                rating += 1;
                _label.Text = "Category" + "\n\n" + recipeCategory + "\n\n\n" +

                    "Ingredients" + "\n\n" + recipeIngredients + "\n\n\n" +

                    "Steps" + "\n\n" + recipeDescription + "\n\n\n\n" +
                    "You liked this recipe " + rating + " times." + "\n";
            }));

            //Bookmark bar button
            ToolbarItems.Add(new ToolbarItem("Bookmark", "bookmark2.png", () =>
            {
                // Click to bookmark
            }));

            // Show content
            Content = sl;
            return;
        }
    }
}