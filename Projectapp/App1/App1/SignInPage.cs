using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class SignInPage : ContentPage
    {
        private SignInViewModel _viewModel;

        private Entry _userName;
        private Button _button;

        public SignInPage(SignInViewModel vm)
        {
            BindingContext = _viewModel = vm;

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
            _button.Clicked += Button_Clicked;

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

        void Button_Clicked(object sender, EventArgs e)
        {
            _viewModel.SignIn();
        }
    }
}
