using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class CroissantsUserControl
    {
        public string Croissants { get; set; }
        public string CroissantsText;

        public CroissantsUserControl()
        {
            Croissants = CroissantsInput();
        }

        public string CroissantsInput()
        {
            CroissantsText = "hi";

            return CroissantsText;
        }
    }
}