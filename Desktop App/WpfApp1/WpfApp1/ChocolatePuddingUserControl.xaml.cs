using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class ChocolatePuddingUserControl
    {
        public string ChocolatePudding { get; set; }
        public string ChocolatePuddingText;

        public ChocolatePuddingUserControl()
        {
            ChocolatePudding = ChocolatePuddingInput();
        }

        public string ChocolatePuddingInput()
        {
            ChocolatePuddingText = "hi";

            return ChocolatePuddingText;
        }
    }
}