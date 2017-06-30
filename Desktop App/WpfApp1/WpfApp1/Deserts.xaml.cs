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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Search results for {this.SearchBox.Text}");
        }

        private void PizzaButton_Click(object sender, RoutedEventArgs e)
        {
            Window5 pizza = new Window5();
            pizza.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void SnacksButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 snacks = new Window1();
            snacks.Show();
            this.Close();
        }


        private void BreakfastButton_Click(object sender, RoutedEventArgs e)
        {
            Window3 breakfast = new Window3();
            breakfast.Show();
            this.Close();
        }

        private void MainDishButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 mainDish = new Window2();
            mainDish.Show();
            this.Close();
        }

        private void DesertButton_Click(object sender, RoutedEventArgs e)
        {
            Window4 desert = new Window4();
            desert.Show();
            this.Close();
        }

        private void BookmarksButton_Click(object sender, RoutedEventArgs e)
        {
            Window6 bookmarks = new Window6();
            bookmarks.Show();
            this.Close();
        }
    }
}
