using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFApp1
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
                return new dbFrench_toast();
            }
            if ((selectedRepice == "Pancakes"))
            {
                return new dbPancakes();
            }
            if ((selectedRepice == "Scrambled eggs"))
            {
                return new dbScrambled_eggs();
            }
            if ((selectedRepice == "Chocolate pudding"))
            {
                return new dbChocolate_pudding();
            }
            if ((selectedRepice == "Strawberry pudding"))
            {
                return new dbStrawberry_pudding();
            }
            if ((selectedRepice == "Vanilla pudding"))
            {
                return new dbVanilla_pudding();
            }
            if ((selectedRepice == "Tiramisu"))
            {
                return new dbTiramisu();
            }
            if ((selectedRepice == "Brownies"))
            {
                return new dbBrownies();
            }
            if ((selectedRepice == "Popcorn"))
            {
                return new dbPopcorn();
            }
            if ((selectedRepice == "Fudge"))
            {
                return new dbFudge();
            }
            if ((selectedRepice == "Nachos"))
            {
                return new dbNachos();
            }
            if ((selectedRepice == "Croissants"))
            {
                return new dbCroissants();
            }
            if ((selectedRepice == "Sheperds Pie"))
            {
                return new dbShepherds_pie();
            }
            if ((selectedRepice == "Hamburger"))
            {
                return new dbHamburger();
            }
            if ((selectedRepice == "Chicken soup"))
            {
                return new dbChicken_soup();
            }
            if ((selectedRepice == "Pasta bolognese"))
            {
                return new dbPasta_bolognese();
            }
            throw new Exception("Error");
        }
    }
}




