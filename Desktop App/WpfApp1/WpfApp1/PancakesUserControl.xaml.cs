using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class PancakesUserControl
    {
        public string Pancakes { get; set; }
        public string PancakesText;

        public PancakesUserControl()
        {
            Pancakes = PancakesInput();
        }

        public string PancakesInput()
        {
            PancakesText = "hi";

            return PancakesText;
        }
    }
}