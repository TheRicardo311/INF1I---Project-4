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
    //The database needs to perform some actions, like sending and retrieving information
    //These actions are declared in this class
    class DbActions
    {
        public void InsertBookmark()
        {
            string Query = @"INSERT INTO bookmark
                             VALUES (" + user_id > +"," + recipe_id + ")";
        }

        public void RetrieveBookmark()
        {
            string Query = @"SELECT * FROM bookmark WHERE user_name = " + user_id + ")";
        }
    }
   
}