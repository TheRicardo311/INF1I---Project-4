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

namespace App1
{
    /// <summary>
    /// Interaction logic for frenchtoast.xaml
    /// </summary>
    public partial class frenchtoast : Window
    {
        public frenchtoast()
        {
            InitializeComponent();
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frenchtoast DFrench_Toast = new frenchtoast();
            DFrench_Toast.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pancakes DPancakes = new Pancakes();
            DPancakes.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Scrambledeggs DScrambleeggs = new Scrambledeggs();
            DScrambleeggs.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Croissant DCroissant = new Croissant();
            DCroissant.Show();
            this.Close();
        }
    }
}
