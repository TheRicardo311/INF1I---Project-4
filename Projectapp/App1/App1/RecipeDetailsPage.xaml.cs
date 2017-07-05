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
        public RecipeDetailsPage(string selectedRecipe)
        {
            InitializeComponent();
            
            // Set title of recipe
            this.Title = selectedRecipe;
            

            // Set stacklayout
            var layout = new StackLayout { Margin = 20 };
            this.Content = layout;

            // Set image
            Image _image = new Image { Source = selectedRecipe + ".jpg" };

            // Set description to label
            Label _label = new Label
            {
                Text = "Add description here for " + selectedRecipe
            };


            // Adding things to screen
            layout.Children.Add(_image);
            layout.Children.Add(_label);
        }
    }
}