using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class ScrambledEggsUserControl
    {
        public string ScrambledEggs { get; set; }
        public string ScrambledEggsText;

        public ScrambledEggsUserControl()
        {
            ScrambledEggs = ScrambledEggsInput();
        }

        public string ScrambledEggsInput()
        {
            ScrambledEggsText = "hi";

            return ScrambledEggsText;
        }
    }
}