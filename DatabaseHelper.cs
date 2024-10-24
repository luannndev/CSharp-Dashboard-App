
using System;
using System.Data.SQLite;

namespace AdvancedDesktopApp
{
    public static class DatabaseHelper
    {
        public static void PerformCRUD()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=data.db;Version=3;"))
            {
                conn.Open();

                string createTableQuery = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY, Name TEXT)";
                SQLiteCommand command = new SQLiteCommand(createTableQuery, conn);
                command.ExecuteNonQuery();

                string insertDataQuery = "INSERT INTO Users (Name) VALUES ('John Doe')";
                command = new SQLiteCommand(insertDataQuery, conn);
                command.ExecuteNonQuery();

                string selectDataQuery = "SELECT Name FROM Users";
                command = new SQLiteCommand(selectDataQuery, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("User: " + reader["Name"]);
                }
            }
        }
    }
}
