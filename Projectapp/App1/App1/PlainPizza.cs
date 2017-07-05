using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    //The plain pizza class, this is the file the decorator uses to add toppings to
    class PlainPizza : IPizza
    {
        public string Name()
        {
            return "De bodem van je pizza, hier ga je dingen aan toevoegen";
        }

        public string Recommandation()
        {
            return null;
        }
    }
}

    