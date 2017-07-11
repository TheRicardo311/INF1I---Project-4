using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WPFApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Sets the main page when the application starts
            MainPage = new MasterDetail();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
