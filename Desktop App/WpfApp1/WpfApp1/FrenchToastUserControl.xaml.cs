using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class FrenchToastUserControl
    {
        public string FrenchToast { get; set; }
        public string FrenchToastText;

        public FrenchToastUserControl()
        {
            FrenchToast = FrenchToastInput();
        }

        public string FrenchToastInput()
        {
            FrenchToastText = "hi";

            return FrenchToastText;
        }
    }
}