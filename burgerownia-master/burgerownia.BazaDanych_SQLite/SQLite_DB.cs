using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using ObiektDwa;

namespace burgerownia.BazaDanych_SQLite
{
    public class SQLite_DB
    {
        SqliteConnectionStringBuilder connectionStringBuilder;
        public SQLite_DB()
        {
            connectionStringBuilder = new SqliteConnectionStringBuilder();
            //Use DB in project directory.  If it does not exist, create it:
            connectionStringBuilder.DataSource = "./SqliteDB.db";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();

                //Create a table (drop if already exists first):

                var delTableCmd = connection.CreateCommand();
                delTableCmd.CommandText = "DROP TABLE IF EXISTS Ingredients";
                delTableCmd.ExecuteNonQuery();

                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = "CREATE TABLE Ingredients (id INTEGER PRIMARY KEY AUTOINCREMENT ,name VARCHAR(50) NOT NULL, price INTEGER NOT NULL)";
                createTableCmd.ExecuteNonQuery();

                //Seed some data:
                SeedData("1 , \'miesko\' , 1000");
                SeedData("2, \'serek\', 500");

                //Read the newly inserted data:
                ReadData();

            }
        }

        private void ReadData()
        {

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Ingredients";

                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var message = reader.GetString(0);
                        var message2 = reader.GetString(1);
                        var message3 = reader.GetString(2);
                        Console.Write(message);
                        Console.Write(message2);
                        Console.WriteLine(message3);
                    }
                }
            }
        }

        public List<Burger> DataToList()
        {
            var burgers = new List<Burger>();
            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Ingredients";

                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var message = reader.GetString(0);
                        var message2 = reader.GetString(1);
                        var message3 = reader.GetString(2);
                        burgers.Add(new Burger("WieśMc", "Burger", new Ingredients(3,3,4).GetAll()));
                    }
                }
            }
            return burgers;
        }

        private void SeedData(string values)
        {
            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    var insertCmd = connection.CreateCommand();

                    insertCmd.CommandText = $"INSERT INTO Ingredients VALUES({values})";
                    insertCmd.ExecuteNonQuery();


                    transaction.Commit();
                }
            }
        }
    }
}

