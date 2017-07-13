using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class ShepherdsPieUserControl
    {
        public string ShepherdsPie { get; set; }
        public string ShepherdsPieText;

        public ShepherdsPieUserControl()
        {
            ShepherdsPie = ShepherdsPieInput();
        }

        public string ShepherdsPieInput()
        {
            ShepherdsPieText = "hi";

            return ShepherdsPieText;
        }
    }
}