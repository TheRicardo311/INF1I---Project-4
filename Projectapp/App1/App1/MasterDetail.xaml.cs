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
    public partial class MasterDetail : MasterDetailPage
    {
        private bool LoggedIn;
        public MasterDetail()
        {
            InitializeComponent();

            // Sets main page to the recipes page
            Detail = new NavigationPage(new MainPage());

            // Hides the menu
            IsPresented = false;
        }


        /// <summary>
        /// Click event that takes the user to recipes page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Recipes_Button(object sender, EventArgs e)
        {
            // Display the main page (recipes page)
            Detail = new NavigationPage(new MainPage());

            // Hides the menu
            IsPresented = false;
        }


        /// <summary>
        /// Click event that takes user to the bookmark page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bookmarks_Button(object sender, EventArgs e)
        {
            // Display the bookmark page
            Detail = new NavigationPage(new BookmarkPage());

            // Hides the menu
            IsPresented = false;
        }


        /// <summary>
        /// Click event that takes user to the suggestions page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Suggestions_Button(object sender, EventArgs e)
        {
            // Display the suggestions page
            Detail = new NavigationPage(new SuggestionPage());

            // Hides the menu
            IsPresented = false;
        }

        /// <summary>
        /// Click event that takes user to the pizza maker page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pizza_Button(object sender, EventArgs e)
        {
            // Display the suggestions page
            Detail = new NavigationPage(new PizzaMaker());

            // Hides the menu
            IsPresented = false;
        }

        /// <summary>
        /// Click event that takes user to the log in page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogIn_Button(object sender, EventArgs e)
        {
            var vm = new SignInViewModel();
            vm.PropertyChanged += SignInViewModel_PropertyChanged;


            if (LoggedIn == false)
            {
                // Display the suggestions page
                Detail = new NavigationPage(new SignInPage(vm));
            }
            else if (LoggedIn == true)
            {
                Detail = new NavigationPage(new ProfilePage());
            }

            // Hides the menu
            IsPresented = false;
        }

        /// <summary>
        /// Funtion that checks if the user is signed in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SignInViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var vm = sender as SignInViewModel;
            switch (e.PropertyName)
            {
                case "SignInRequired":
                    {
                        if (vm.SignInRequired)
                        {
                            if (!(Detail is SignInPage))
                            {
                                Detail = new NavigationPage(new SignInPage(vm));
                            }
                        }
                        else
                        {
                            Detail = new NavigationPage(new ProfilePage());
                            LoggedIn = true;
                        }
                        break;
                    }
            }
        }
    }
}