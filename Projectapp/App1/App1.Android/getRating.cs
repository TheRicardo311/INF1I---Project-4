using System;
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
    //Implements methods from IRating
    abstract class getRating : IRating
    {
        IRating tempRating;

        //New temporary Rating
        public getRating (IRating newRating)
        {
            tempRating = newRating;
        }
        //Uses the getDescription method from the IRating interface
        public float obtainRating()
        {
            return 0;
        }
    }
}