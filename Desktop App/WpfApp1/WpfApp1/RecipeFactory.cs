using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    abstract class RecipeFactory
    {
        public abstract Recipe Create(string selectedRepice);

    }

    class ConcreteRecipeFactory : RecipeFactory
    {
        public override Recipe Create(string selectedRepice)
        {
            if ((selectedRepice == "French Toast"))
            {
                return new French_toast();
            }
            if ((selectedRepice == "Pancakes"))
            {
                return new Pancakes();
            }
            if ((selectedRepice == "Scrambled eggs"))
            {
                return new Scrambled_eggs();
            }
            if ((selectedRepice == "Chocolate pudding"))
            {
                return new Chocolate_pudding();
            }
            if ((selectedRepice == "Strawberry pudding"))
            {
                return new Strawberry_pudding();
            }
            if ((selectedRepice == "Vanilla pudding"))
            {
                return new Vanilla_pudding();
            }
            if ((selectedRepice == "Tiramisu"))
            {
                return new Tiramisu();
            }
            if ((selectedRepice == "Brownies"))
            {
                return new Brownies();
            }
            if ((selectedRepice == "Popcorn"))
            {
                return new Popcorn();
            }
            if ((selectedRepice == "Fudge"))
            {
                return new Fudge();
            }
            if ((selectedRepice == "Nachos"))
            {
                return new Nachos();
            }
            if ((selectedRepice == "Croissants"))
            {
                return new Croissants();
            }
            if ((selectedRepice == "Sheperds Pie"))
            {
                return new Shepherds_pie();
            }
            if ((selectedRepice == "Hamburger"))
            {
                return new Hamburger();
            }
            if ((selectedRepice == "Chicken soup"))
            {
                return new Chicken_soup();
            }
            if ((selectedRepice == "Pasta bolognese"))
            {
                return new Pasta_bolognese();
            }
            throw new Exception("Error");
        }
    }
}




