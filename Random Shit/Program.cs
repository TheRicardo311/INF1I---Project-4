using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace TESTTT
{
    class Program
    {
        static void Main(string[] args)
        {
            string server = "145.132.52.248";
            string port = "8457";
            string database = "Project4";
            string uid = "project4";
            string password = "hetrapportvanpim";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            MySqlDataReader mdr;
            string output;


            conn.Open();

            System.Console.WriteLine("Enter user_id: ");

            string id = System.Console.ReadLine().ToString();

            string Query = "SELECT * FROM user WHERE user_id= " + id;

            cmd = new MySqlCommand(Query, conn);

            mdr = cmd.ExecuteReader();

            if (mdr.Read())
            {
                output = mdr.GetString("user_name");
                System.Console.WriteLine("The username is " + output);
            }
            else
            {
                System.Console.WriteLine("INVALID USER ID");
            }

            conn.Close();

            System.Console.ReadKey();
        }
    }
}
