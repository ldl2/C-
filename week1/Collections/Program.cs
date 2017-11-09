using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAYS
            //create an array to hold integer values 0 through 9
            int[] tenArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            foreach (int num in tenArray ){
                Console.WriteLine(num);
            };
            //create an array of the names 
            string[] nameArray = new string[4]{
                "Tim",
                "Martin",
                "Nikki",
                "Sara"
            }; 
            foreach (string name in nameArray){
                Console.WriteLine(name);
            };

            //Array of 10 length alternate TorF  
            bool[] altArray = new bool[10]
            {true, false, true, false, true, false, true, false, true, false};
            int [,] multArray = new int[10,10];

            for (int row = 1; row <= 10; row++){
                for(int col = 1; col <= 10; col++){
                    int val = col * row;
                    multArray[row-1, col-1] = val;
                };
            };
            
            Console.WriteLine(multArray);
            //LISTS
            //Create a list of Ice Cream flavors with 5 flavors
            List<string> IceCream = new List<string>();
            IceCream.Add("Vanilla");
            IceCream.Add("Chocolate");
            IceCream.Add("Strawberry");
            IceCream.Add("Neopolitan");
            IceCream.Add("Rockey Road");

            foreach (string flavor in IceCream){
                Console.WriteLine(flavor);
            };
            Console.WriteLine(IceCream.Count);
            Console.WriteLine(IceCream[2]);
            IceCream.Remove("Strawberry");
            Console.WriteLine(IceCream.Count);

            Dictionary<string, string> fresh = new Dictionary<string, string>();
            
            foreach (string name in nameArray)
            {
                Random Rand = new Random();
                int laCrema = Rand.Next(0,4);

                fresh.Add(name, IceCream[laCrema]);
            };
            foreach (KeyValuePair<string, string> pair in fresh)
            {
                Console.WriteLine($"{pair.Key} is a fan of {pair.Value}");
            }

        }
            
            
    }
}
