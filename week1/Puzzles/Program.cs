using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static Array RandomArray()
        {
            //sets up random array
            int[] randdum = new int[10];
            Random rand = new Random();

            //creates random array
            for (int i = 0; i < 10; i++)
            {
                randdum[i] = rand.Next(5,25);
            }

            //initializes our min max and sum as just the first item in array/0
            int min = randdum[0];
            int max = randdum[0];
            int sum = 0;

            //iterate throgh random array findiign min max and making sum
            for (int j = 0; j < 10; j++)
            {
                if (randdum[j] < min)
                {
                    min = randdum[j];
                }
                if (randdum[j] > max)
                {
                    max = randdum[j];
                }
                sum += randdum[j];
            }
            
            Console.WriteLine($"The min is: {min}, The max is {max}, and the sum is {sum}");
            return randdum;
        }
        public static string CoinFlip()
        {
            //sets random up for coin flipping
            Random coin = new Random();
            int flip = coin.Next(1,3);
            
            //initializes a results
            string result = null;
            
            //logic part that converts number from random to string
            if(flip==1)
            {
                result = "heads";
            }
            else
            {
                result = "tails";
            }
            //send back string result
            return result;
        }
        public static double TossMultipleCoins(int num)
        {
            //initialize all our variables heads is a count
            //final is basically null until we get to the math
            int heads = 0;
            double final = 0;

            //logic that sets up how many flips pulls num argument above
            for(int i = 0; i<=num; i++)
            {
                string result = CoinFlip();
                if (result == "heads")
                {
                    heads+=1;
                }
            }
            final = heads/(double)num;

        return final;
        }
        public static Array Shuffle()
        {
            
            string[] bleb = {"Todd","Tiffany","Charlie","Geneva","Sydney"};
            int len = bleb.Length;
            Random random = new Random();
            for (int wordspot = 0; wordspot<len; wordspot++)
            {
                int rndnum = wordspot + random.Next(len-3);
                string tmp = bleb[rndnum];
                bleb[rndnum] = bleb[wordspot];
                bleb[wordspot] = tmp;
            }
            return bleb;
        }
        public static Array down4()
        {
            //initialize our variables done here shoudl probably do as a par/arg but already did this
            string[] bleb = {"Todd","Tiffany","Charlie","Geneva","Sydney"};
            int count = 0;
            

            //logicto find less than fors
            for(int i=0; i<bleb.Length; i++)
            {
                if (bleb[i].Length<4)
                {
                    count +=1;
                }
            }

            //another set of values to set-creates string and count here
            //note pulls count from above that to set its length
            string[] newbleb = new string[bleb.Length-count];
            int count1 = 0;

            //loops through old loop putting into new loop based on same find
            for(int j=0; j<bleb.Length; j++)
            {
                if (bleb[j].Length<4)
                {
                    count1 +=1;
                }
                else
                {
                    newbleb[j-count1]=bleb[j];
                }
            }
        return newbleb;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many times to you want to flip a coin?: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(TossMultipleCoins(input));

            foreach (string rube in Shuffle())
            {
                Console.WriteLine("A random name is {0}", rube);
            }
            foreach(string rube in down4())
            {
                Console.WriteLine("A name longer than 4 is {0}", rube);
            }
            foreach(int rube in RandomArray())
            {
                Console.WriteLine(rube);
            }
        }
        

    }
}
