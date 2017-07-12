using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Drawing;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        //Home Button
        public Window3()
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

        private void DFrenchToastButton_Click(object sender, RoutedEventArgs e)
        {
            WindowContent.Content = new FrenchToastUserControl();
        }

        public void Recipe1_viewbox()
        {


            //Viewbox Recipe1 = new Viewbox();
            //Recipe1.HorizontalAlignment = HorizontalAlignment.Left;
            //Recipe1.Width = 300;



            //TextBox Recipe1Text = new TextBox();
            
            //Recipe1Text.HorizontalAlignment = HorizontalAlignment.Left;
            //Recipe1Text.Height = 77;
            //Recipe1Text.Margin = new Thickness (89, 113, 0, 0);
            //Recipe1Text.TextWrapping = TextWrapping.Wrap;
            //Recipe1Text.VerticalAlignment = VerticalAlignment.Top;
            //Recipe1Text.Foreground = new SolidColorBrush();
            //Recipe1Text.MaxWidth = 200;
            //Recipe1Text.Margin = new Thickness(0, 0, 5, 0);
            //Recipe1Text.TextWrapping = TextWrapping.Wrap;
            //Recipe1Text.Foreground = new SolidColorBrush(Colors.White);

            //Recipe1Text.Text = "Let's see how this works";
            // <TextBlock HorizontalAlignment="Left" Height="77" Margin="89,113,0,0" TextWrapping="Wrap" Text="TextBlock" VerticalAlignment="Top" Width="148" Foreground="#FFF5F0F0" Background="Black"/>

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //return Recipe1_viewbox
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
            Window3 Dbreakfast = new Window3();
            Dbreakfast.Show();
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
