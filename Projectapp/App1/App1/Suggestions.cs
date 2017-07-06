using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    public class Suggestions
    {
        Random rnd = new Random();

        public string GetRandomRecipe()
        {
            Singleton newInstance = Singleton.getInstance();

            List<string> RandomRecipeLists = newInstance.CreateList();
            string RandomRecipe = RandomRecipeLists[rnd.Next(RandomRecipeLists.Count)];

            return RandomRecipe;
        }

    }
}