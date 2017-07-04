using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    //The plain pizza class, this is the file the decorator uses to add toppings to
    class PlainPizza : IPizza
    
    {
        //Uses the getDescription method from the IPizza interfacea
        public string getDescription()
        {
            return "A plain pizza you can add toppings to";
        }
    }
}

    