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

            this.Title = selectedRecipe;
            var layout = new StackLayout
            {
                Margin = 20
            };
            this.Content = layout;

            
            //return new ContentPage
            //{
            //    Content = new Label
            //    {
            //        Text = "Hello, Forms!",
            //        VerticalOptions = LayoutOptions.CenterAndExpand,
            //        HorizontalOptions = LayoutOptions.CenterAndExpand,
            //    };
            //}
        }
    }
}