using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var x = from arty in Artists
                    where arty.Hometown == "Mount Vernon"
                    select new {arty.ArtistName, arty.RealName, arty.Age };
            foreach (object item in x)
            {
                Console.WriteLine(item);
            }
            var y = Artists
            .Where(farty =>farty.Hometown=="Mount Vernon").ToList();
            foreach (var item in y)
            {
                Console.WriteLine("Artist Name: {0}, Real Name: {1}, Age: {2}", item.ArtistName, item.RealName, item.Age);
            }
            //Who is the youngest artist in our collection of artists?

            var youngest = Artists.OrderBy(artist =>artist.Age).ToList().First();
            Console.WriteLine($"The name is {youngest.ArtistName} originally called {youngest.RealName}");

            //Display all artists with 'William' somewhere in their real name
            var willie = Artists.Where(artist => artist.RealName
            .Contains("William")).ToArray();
            foreach (var will in willie)
            {
                Console.WriteLine($"The name is {will.ArtistName} originally called {will.RealName}");
            }
            //Display the 3 oldest artist from Atlanta
            var city = Artists.Where(artist =>artist.Hometown == "Atlanta")
            .OrderByDescending(artist => artist.Age).Take(3).ToArray();
            foreach (var ATL in city)
            {
                Console.WriteLine($"The artist is {ATL.ArtistName} and they are from {ATL.Hometown}");
            }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
