using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for Fudge.xaml
    /// </summary>
    public partial class Fudge : Window
    {
        DataBaseYo _db = new DataBaseYo();
        public Fudge()
        {
            InitializeComponent();

            string _recipe = Title;

            string _ingr = _db.getText(_recipe, "ingredients");
            string _desc = _db.getText(_recipe, "description");

            TitleHere.Text = _recipe;
            Ingr.Text = _ingr;
            Desc.Text = _desc;
        }
        private void DHomeButton_Click(object sender, RoutedEventArgs e)
        {
            Window7 DMainWindow = new Window7();
            DMainWindow.Show();
            this.Close();
        }

        //Search Button
        private void DSearchButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Search results for {this.DSearchBox.Text}");
        }

        //Pizza Button
        private void DPizzaButton_Click(object sender, RoutedEventArgs e)
        {
            Window5 Dpizza = new Window5();
            Dpizza.Show();
            this.Close();
        }

        //Snacks Button
        private void DSnacksButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 Dsnacks = new Window1();
            Dsnacks.Show();
            this.Close();
        }

        //Dessert Button
        private void DDesertButton_Click(object sender, RoutedEventArgs e)
        {
            Window4 Ddesert = new Window4();
            Ddesert.Show();
            this.Close();
        }

        //Main Dish Button
        private void DMainDishButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 DmainDish = new Window2();
            DmainDish.Show();
            this.Close();
        }

        //Breakfast Button
        private void DBreakfastButton_Click(object sender, RoutedEventArgs e)
        {
            Window3 Dbreakfast = new Window3();
            Dbreakfast.Show();
            this.Close();
        }

        //Login Screen Button
        private void DBookmarksButton_Click(object sender, RoutedEventArgs e)
        {
            Window6 Dbookmarks = new Window6();
            Dbookmarks.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Snacks_1(object sender, RoutedEventArgs e)
        {
            Brownies DBrownies = new Brownies();
            DBrownies.Show();
            this.Close();
        }

        private void Snacks_2(object sender, RoutedEventArgs e)
        {
            Nachos DNachos = new Nachos();
            DNachos.Show();
            this.Close();
        }

        private void Snacks_3(object sender, RoutedEventArgs e)
        {
            Fudge DFudge = new Fudge();
            DFudge.Show();
            this.Close();
        }

        private void Snacks_4(object sender, RoutedEventArgs e)
        {
            Popcorn DPopcorn = new Popcorn();
            DPopcorn.Show();
            this.Close();
        }
    }
}

