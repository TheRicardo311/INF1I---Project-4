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
    }
}