using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    //The plain pizza class, this is the file the decorator uses to add toppings to
    class PlainPizza : APizza
    {
        private string adding;
        public override void getDescription()
        {
            adding = "Baking a nice hot pizza for you";
        }
    }
}

    