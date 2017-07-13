using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class PopcornUserControl
    {
        public string Popcorn { get; set; }
        public string PopcornText;

        public PopcornUserControl()
        {
            Popcorn = PopcornInput();
        }

        public string PopcornInput()
        {
            PopcornText = "hi";

            return PopcornText;
        }
    }
}