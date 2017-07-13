using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    public partial class FudgeUserControl
    {
        public string Fudge { get; set; }
        public string FudgeText;

        public FudgeUserControl()
        {
            Fudge = FudgeInput();
        }

        public string FudgeInput()
        {
            FudgeText = "hi";

            return FudgeText;
        }
    }
}