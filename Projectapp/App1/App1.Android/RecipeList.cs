﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1.Droid
{
    public class Recipe extends RecipeFactory
    {
        setName("Recipe 1");
        setIDNumber(1);
        setIngredients();
    }
}