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
    class Button_Adapter : Window2
    {
        object sender;
        RoutedEventArgs e;
        Window7 AdapterButton;
        public Button_Adapter(Window7 newButton)
        {
            AdapterButton = newButton;
        }
        public void DHomeButton_Click()
        {
            AdapterButton.DAdapterHomeButton_Click(sender, e);
        }

    }
}
