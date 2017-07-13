using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class StrawberryPuddingUserControl
    {
        public string StrawberryPudding { get; set; }
        public string StrawberryPuddingText;

        public StrawberryPuddingUserControl()
        {
            StrawberryPudding = StrawberryPuddingInput();
        }

        public string StrawberryPuddingInput()
        {
            StrawberryPuddingText = "hi";

            return StrawberryPuddingText;
        }
    }
}