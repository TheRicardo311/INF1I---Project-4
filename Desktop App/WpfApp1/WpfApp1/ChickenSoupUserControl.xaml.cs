using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class ChickenSoupUserControl
    {
        public string ChickenSoup { get; set; }
        public string ChickenSoupText;

        public ChickenSoupUserControl()
        {
            ChickenSoup = ChickenSoupInput();
        }

        public string ChickenSoupInput()
        {
            ChickenSoupText = "hi";

            return ChickenSoupText;
        }
    }
}