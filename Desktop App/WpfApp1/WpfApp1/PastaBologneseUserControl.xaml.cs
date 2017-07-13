using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class PastaBologneseUserControl
    {
        public string PastaBolognese { get; set; }
        public string PastaBologneseText;

        public PastaBologneseUserControl()
        {
            PastaBolognese = PastaBologneseInput();
        }

        public string PastaBologneseInput()
        {
            PastaBologneseText = "hi";

            return PastaBologneseText;
        }
    }
}