using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class TiramisuUserControl
    {
        public string Tiramisu { get; set; }
        public string TiramisuText;

        public TiramisuUserControl()
        {
            Tiramisu = TiramisuInput();
        }

        public string TiramisuInput()
        {
            TiramisuText = "hi";

            return TiramisuText;
        }
    }
}