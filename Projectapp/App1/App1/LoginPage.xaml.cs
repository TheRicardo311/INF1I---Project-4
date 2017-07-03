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
    public partial class LoginPage : ContentPage
    {
        Button _button;
        Entry _userName;

        public LoginPage()
        {
            InitializeComponent();

            _userName = new Entry
            {
                Placeholder = "Username",
                HorizontalTextAlignment = TextAlignment.Center,
                PlaceholderColor = Color.Black,
                BackgroundColor = Color.White
            };

            _button = new Button
            {
                Text = "Log in",
            };
            _button.Clicked += Login_Click;

            Content = new StackLayout
            {
                BackgroundColor = Color.Black,
                Children =
                {
                    _userName,
                    _button,
                }
            };
        }


        void Login_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage(_userName.Text));
        }
    }
}