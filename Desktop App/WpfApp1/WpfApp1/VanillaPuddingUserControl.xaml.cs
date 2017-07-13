using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class VanillaPuddingUserControl
    {
        public string VanillaPudding { get; set; }
        public string VanillaPuddingText;

        public VanillaPuddingUserControl()
        {
            VanillaPudding = VanillaPuddingInput();
        }

        public string VanillaPuddingInput()
        {
            VanillaPuddingText = "hi";

            return VanillaPuddingText;
        }
    }
}