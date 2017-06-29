using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When filter button clicked, filter page pops up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filter_Button(object sender, EventArgs e)
        {
            // Shows the filter page
            Navigation.PushAsync(new FilterPage());
        }
    }
}
