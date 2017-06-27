using System;
using System.Collections.Generic;
using Android.Views;
using MySql.Data.MySqlClient;


namespace App1.Droid
{

    public class DbConnect : IConnection
        {
            private MySqlConnection connection;
            private string server;
            private string database;
            private string uid;
            private string password;

            //Constructor
            public void DbConnection()
            {
                Initialize();
            }

            public void CloseConnection()
            {
                throw new NotImplementedException();
            }

            public void dbCommand(string sqlQuery)
            {
                throw new NotImplementedException();
            }

            public void InsertIntoDB()
            {
                throw new NotImplementedException();
            }

            public void OpenConnection()
            {
                throw new NotImplementedException();
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
                /*
                //open connection to database
                private bool OpenConnection()
                {
                }

                //Close connection
                private bool CloseConnection()
                {
                }

                //Insert statement
                public void Insert()
                {
                }

                //Update statement
                public void Update()
                {
                }

                //Delete statement
                public void Delete()
                {
                }

                //Select statement
                public List<string>[] Select()
                {
                }

                //Count statement
                public int Count()
                {
                }

                //Backup
                public void Backup()
                {
                }

                //Restore
                public void Restore()
                {
                }
            }

            /// <summary>
            /// Create database tabbles
            /// </summary>
            public void CreateDB()
            {
                string sqlQuery = @"DROP TABLE IF EXISTS criminality;
                                    DROP TABLE IF EXISTS bike_possession;
                                    DROP TABLE IF EXISTS car_possession;
                                    DROP TABLE IF EXISTS lamps;
                                    DROP TABLE IF EXISTS people;

                                    CREATE TABLE lamps 
                                    ( 
                                        longitude float(32), 
                                        latitude float(32), 
                                        neighborhood varchar(32),
                                        year year
                                    );

                                     CREATE TABLE car_possession
                                    (
                                        neighborhood varchar(69),
                                        total int
                                    );


                                    CREATE TABLE bike_possession
                  	                (
                                        neighborhood varchar(69),
                                        total int
                                    );
        
                                    CREATE TABLE criminality
                                    (
                                        neighborhood varchar(69),
                                        year_2006 int,
                                        year_2007 int,
                                        year_2008 int,
                                        year_2009 int,
                                        year_2011 int

					                );
                                
                                    CREATE TABLE people
                                    (
                                        neighborhood varchar(69),
                                        total int
                                    );";

                this.dbCommand(sqlQuery);
            }


            /// <summary>
            /// Insert data into database
            /// </summary>
            public void InsertIntoDB()
            {
                string sqlQuery = @"INSERT INTO car_possession
                                    VALUES ('Stadscentrum', 40),
		                                    ('Delfshaven', 30),
		                                    ('Overschie', 58),
		                                    ('Kralingen_Crooswijk', 42),
		                                    ('Noord', 38),
		                                    ('Hillegersberg_Schiebroek', 56),
		                                    ('Prins_Alexander', 48),
		                                    ('Feijenoord', 32),
		                                    ('IJsselmonde', 46),
		                                    ('Charlois', 43),
		                                    ('Hoogvliet_Pernis', 42),
		                                    ('Hoek_van_Holland', 49);

                                    INSERT INTO bike_possession
                                    VALUES ('Stadscentrum', 67),
		                                    ('Delfshaven', 54),
		                                    ('Overschie', 73),
		                                    ('Kralingen_Crooswijk', 64),
		                                    ('Noord', 71),
		                                    ('Hillegersberg_Schiebroek', 76),
		                                    ('Prins_Alexander', 75),
		                                    ('Feijenoord', 53),
		                                    ('IJsselmonde', 66),
		                                    ('Charlois', 58),
		                                    ('Hoogvliet_Pernis', 72),
		                                    ('Hoek_van_Holland', 81);

                                    INSERT INTO criminality
                                    VALUES  ('Charlois', 330, 318, 303, 298, 343),
                                            ('Delfshaven', 323, 335, 386, 312, 411),
                                            ('Feijenoord', 259, 275, 337, 294, 303),
                                            ('Hillegersberg_Schiebroek', 295, 201, 222, 295, 286),
                                            ('Hoek_van_Holland', 74, 59, 84, 110, 95),
                                            ('IJsselmonde', 334, 362, 340, 343, 316),
                                            ('Kralingen_Crooswijk', 429, 470, 343, 341, 431),
                                            ('Noord', 448, 500, 463, 401, 466),
                                            ('Overschie', 85, 55, 63, 51, 82),
                                            ('Hoogvliet_Pernis', 22, 22, 31, 22, 28),
                                            ('Prins_Alexander', 588, 527, 838, 759, 611),
                                            ('Rozenburg', -1, -1, -1, 84, 38),
                                            ('Stadscentrum', 563, 628, 1179, 571, 721);

                                    INSERT INTO people
                                    VALUES  ('Charlois', 66180),
                                            ('Delfshaven', 75445),
                                            ('Feijenoord', 73490),
                                            ('Hillegersberg_Schiebroek', 43580),
                                            ('Hoek_van_Holland', 10155),
                                            ('IJsselmonde', 59630),
                                            ('Kralingen_Crooswijk', 53165),
                                            ('Noord', 51690),
                                            ('Overschie', 6710),
                                            ('Hoogvliet_Pernis', 4785),
                                            ('Prins_Alexander', 94600),
                                            ('Rozenburg', 12420),
                                            ('Stadscentrum', 32925)";

                this.dbCommand(sqlQuery);
            }

            /// <summary>
            /// Opens connection to database
            /// </summary>
            public void OpenConnection()
            {
                conn.ConnectionString = "SERVER = localhost;" +
                                        "Database = datasetsproject3;" +
                                        "User ID = root;" +
                                        "Password = root;";

                conn.Open();
            }

            /// <summary>
            /// Closes connection to database
            /// </summary>
            public void CloseConnection()
            {
                conn.Close();
            }

            /// <summary>
            /// Sends query to database
            /// </summary>
            /// <param name="sqlQuery"> the sql query to be executed </param>
            public void dbCommand(string sqlQuery)
            {
                this.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }

            /// <summary>
            /// Gets the neighborhoods from the DB
            /// </summary>
            /// <returns>List<BarItem></returns>
            public List<string> getNeighborhoodsFromDB()
            {
                string sqlQuery = "SELECT DISTINCT(neighborhood) FROM lamps;";

                this.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    neighborhoods.Add(reader.GetString(0));
                }

                neighborhoods.Sort();

                this.CloseConnection();

                return neighborhoods;
            }

            /// <summary>
            /// Gets the number of people with bikes per neigborhood divided by lamps
            /// </summary>
            /// <returns>List<BarItem></returns>
            public List<BarItem> getBikeData()
            {
                List<BarItem> bikeData = new List<BarItem>();
                string sqlQuery = @"SELECT bike_possession.neighborhood, ROUND((people.total * bike_possession.total)/ COUNT(lamps.neighborhood)) AS 'people_w/_bike_per_lamp'
                                    FROM lamps, bike_possession, people
                                    WHERE lamps.neighborhood = bike_possession.neighborhood AND lamps.neighborhood = people.neighborhood AND lamps.year <= 2009
                                    GROUP BY bike_possession.neighborhood;";

                this.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    bikeData.Add(new BarItem { Value = reader.GetDouble(1) });
                }

                this.CloseConnection();

                return bikeData;
            }

            /// <summary>
            /// Gets the number of people with cars per neigborhood divided by lamps
            /// </summary>
            /// <returns>List<BarItem></returns>
            public List<BarItem> getCarData()
            {
                List<BarItem> carData = new List<BarItem>();
                string sqlQuery = @"SELECT lamps.neighborhood, ROUND((people.total * car_possession.total) / COUNT(lamps.neighborhood)) AS 'people_w/_car_per_lamp'
                                    FROM lamps, car_possession, people
                                    WHERE lamps.neighborhood = car_possession.neighborhood AND lamps.neighborhood = people.neighborhood AND lamps.year <= 2009
                                    GROUP BY lamps.neighborhood;";

                this.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    carData.Add(new BarItem { Value = reader.GetDouble(1) });
                }

                this.CloseConnection();

                return carData;
            }
            */
        }
    }
