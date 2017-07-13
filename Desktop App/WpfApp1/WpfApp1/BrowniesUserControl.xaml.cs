using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class BrowniesUserControl
    {
        public string Brownies { get; set; }
        public string BrowniesText;

        public BrowniesUserControl()
        {
            Brownies = BrowniesInput();
        }

        public string BrowniesInput()
        {
            BrowniesText = "hi";

            return BrowniesText;
        }
    }
}