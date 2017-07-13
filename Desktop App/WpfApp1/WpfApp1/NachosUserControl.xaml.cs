using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class NachosUserControl
    {
        public string Nachos { get; set; }
        public string NachosText;

        public NachosUserControl()
        {
            Nachos = NachosInput();
        }

        public string NachosInput()
        {
            NachosText = "hi";

            return NachosText;
        }
    }
}