using System;
using System.Collections.Generic;
using Android.Views;
using MySql.Data.MySqlClient;


namespace App1.Droid
{

    public class DbConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        
        //Constructor
        public DbConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "145.132.52.248";
            database = "Project4";
            uid = "project4";
            password = "hetrapportvanpim";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //Open the connection to the database
        private void OpenConnection()
        {
            connection.Open();
        }

        //Close the connection to the database
        private void CloseConnection()
        {
            connection.Close();
        }
        /*
        //Insert user statement
        public void InsertUser(user_id, user_name, user_pass)
        {
            string query = "INSERT INTO tableinfo (user_id, 4) VALUES('Bob', 'Henkmeister')";

            //Open connection
            this.OpenConnection();

            //Create command for the query
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //Close connection
            this.CloseConnection();
            
        //Insert user statement
        public void InsertLikes(user_id, recept,id)
        {
            string query = "INSERT INTO tableinfo (user_id, 4) VALUES('Bob', 'Henkmeister')";

            //Open connection
            this.OpenConnection();

            //Create command for the query
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //Close connection
            this.CloseConnection();

        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            this.OpenConnection();

            //Create the command
            MySqlCommand cmd = new MySqlCommand();

            //Assign the query using CommandText
            cmd.CommandText = query;

            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            //Close connection
            this.CloseConnection();
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            //Open connection
            this.OpenConnection();

            //Create the command
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute query
            cmd.ExecuteNonQuery();

            //Close connection
            this.CloseConnection();
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            this.OpenConnection();

            //Create command
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                list[0].Add(dataReader["id"] + "");
                list[1].Add(dataReader["name"] + "");
                list[2].Add(dataReader["age"] + "");
            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return list;



        }
        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            this.OpenConnection();
            
            //Create Mysql Command
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //ExecuteScalar will return one value
            Count = int.Parse(cmd.ExecuteScalar() + "");

            //close Connection
            this.CloseConnection();

            return Count;
            
            
        }
        */
    }
}