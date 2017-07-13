using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class HamburgerUserControl
    {
        public string Hamburger { get; set; }
        public string HamburgerText;

        public HamburgerUserControl()
        {
            Hamburger = HamburgerInput();
        }

        public string HamburgerInput()
        {
            HamburgerText = "hi";

            return HamburgerText;
        }
    }
}