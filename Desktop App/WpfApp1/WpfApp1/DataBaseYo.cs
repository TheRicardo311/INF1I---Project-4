using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WPFApp1
{
    class DataBaseYo
    {
        private MySqlConnection connection;
        private MySqlCommand cmd;
        private MySqlDataReader mdr;
        private string server;
        private string database;
        private string userid;
        private string password;


        //Constructor
        public DataBaseYo()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "Project4";
            userid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "Database=" +
                database + ";" + "User ID=" + userid + ";" + "Password=" + password + ";";

            connection = new MySqlConnection(connectionString);


            string sqlQuery = @"DROP TABLE IF EXISTS bookmarks;
                                DROP TABLE IF EXISTS recipe;

                                        CREATE TABLE recipe
                                        (
                                            recipe_name varchar(32),
                                            ingredients varchar(6666),
                                            description varchar(6666),
        				                    category varchar(25)
                                        );

                                        CREATE TABLE bookmarks(
	                                        user_id int,
	                                        user_name varchar(33),
	                                        recipe_name varchar(6666)
                                        );

                                        INSERT INTO recipe
                                        VALUES ('French toast', '1/4 teaspoon ground nutmeg, 1 teaspoon ground cinnamon, 2 tablespoons sugar, 4 tablespoons butter, 4 eggs, 
        1/4 cup milk, 1/2 teaspoon vanilla extract, 8 slices challah, brioche, or white bread, 1/2 cup maple syrup', 'In a small bowl, combine, cinnamon, nutmeg, and sugar and set aside briefly.In a 10-inch or 12-inch skillet, melt butter over medium heat. Whisk together cinnamon mixture, eggs, milk, and vanilla and pour into a shallow container such as a pie plate. Dip bread in egg mixture. Fry slices until golden brown, then flip to cook the other side. Serve with syrup.', 'breakfast');

                                        INSERT INTO bookmarks
                                        VALUES (1, 'Henk', 'French Toast'),
                                                (2, 'Ricardo', 'Pancakes')";

            this.dbCommand(sqlQuery);
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

        //Insert user statement
        public void InsertUser(int user_id, string user_name, string user_pass)
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

        //Insert user statement
        public void InsertLikes(string user_id, int recept_id)
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

        // Database command
        public void dbCommand(string sqlQuery)
        {
            this.OpenConnection();
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            this.CloseConnection();
        }

        public bool getUsername(string _userName)
        {
            string output;

            this.OpenConnection();

            string sqlQuery = @"SELECT * FROM bookmarks WHERE user_name="+ "'" + _userName + "'";
            cmd = new MySqlCommand(sqlQuery, connection);

            mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                output = mdr.GetString("user_name");
                if (output == _userName)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            this.CloseConnection();

            return false;
        }
    }
}
