using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    //The database needs to perform some actions, like sending and retrieving information
    //These actions are declared in this class
    class DbActions
    {
        private string user_id;
        private string user_name;
        private string recipe_id;

        public void Login()
        {
            string Query = @"SELECT * FROM user WHERE" + user_id + "=" + user_name + " AND password = SHA('$password')";
        }
        public void InsertBookmark()
        {
            string Query = @"INSERT INTO bookmark
                             VALUES (" + user_id + ", " + recipe_id + ")";
         
        }

        public void RetrieveBookmark()
        {
            string Query = "SELECT * FROM bookmark WHERE user_name = " + user_id + ")";
        }

        
    }
   
}