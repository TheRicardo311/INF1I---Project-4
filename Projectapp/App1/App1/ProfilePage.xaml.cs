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
    public partial class ProfilePage : ContentPage
    {
        Label _label;

        public ProfilePage(string name)
        {
            InitializeComponent();

            var layout = new StackLayout
            {
                Padding = new Thickness(5, 10),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            this.Content = layout;
            var label = new Label
            {
                Text = "Welcome " + name,
                TextColor = Color.FromHex("#77d065"),
                FontSize = 20,
            };
            layout.Children.Add(label);
        }

        private void LogOut_Button(object sender, EventArgs e)
        {
            InitializeComponent();
            var layout = new StackLayout { Padding = new Thickness(5, 10) };
            this.Content = layout;

            _label = new Label
            {
                Text = "LOGGED OUT "
            };

            layout.Children.Add(_label);
        }
    }
}