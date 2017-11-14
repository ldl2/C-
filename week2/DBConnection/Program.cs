using System;
using DbConnection;
using DBConnection;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnector.Query("SELECT * FROM Users");
            System.Console.WriteLine("Please add another user, with each part on a new line, First Name, Last Name, and Favorite Number");
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            string tip = Console.ReadLine();
            int FavoriteNumber = Convert.ToInt32(tip);
            DbConnector.Execute($"INSERT INTO Users (FirstName, LastName, FavoriteNumber) VALUES ('{FirstName}', '{LastName}', '{FavoriteNumber}')");
            
        }
    }
}
