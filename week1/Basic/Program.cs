using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pizza = {2,10,3,-5,5};
            int[] pizza2 = {2,10,3,-5,5};
            int[] pizza3 = {2,10,3,-5,5};
            first();
            second();
            third();
            fourth();
            fifth(pizza);
            sixth(pizza);
            seventh();
            eighth(pizza, 3);
            ninth(pizza);
            tenth(pizza2);
            eleventh(pizza3);
            twelth(pizza3);
        }
        public static void first()
        {
            for(int num = 1; num <= 255; num++)
            {
                Console.WriteLine(num);
            }
        }
        public static void second()
        {
            
            for (int num = 1; num <= 255; num++)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
        

        public static void third()
        {
            int addIt = 0;
            for (int num = 1; num <= 255; num++)
            {
                addIt += num;
                Console.WriteLine("New number: {0} Sum: {1}", num, addIt);
            }
        }
        public static void fourth()
        {
            int[] x = {1,3,5,7,8,13};
            foreach (int num in x)
            {
                Console.WriteLine(num);
            }
        }
        public static void fifth(int[] x)
        {
            int sum = 0;
            int av = 0;
            foreach (int num in x)
            {
                sum +=num;
                av= sum/x.Length;
            }
        Console.WriteLine(av);
        }
        
        public static void sixth(int[] x)
        {
            int min = 0;
            foreach (int num in x)
            {
                if (min<=num)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
        public static void seventh()
        {
            int[] blerb = new int[128];
            int y=1;
            for (int x = 0; x <= 127; x += 1)
            {
                
                {
                   blerb[x] = y;
                   Console.WriteLine(blerb[x]);
                }
                y += 2;
            }
        }
        public static void eighth(int[] x, int y)
        {
            int sum = 0;
            foreach (int num in x)
            {
                if (num <= y)
                {
                    sum +=1;
                }
            }
            Console.WriteLine(sum);
        }
        public static void ninth(int[] x)
        {
            for(int y=0; y<x.Length; y++){
                x[y]=x[y]*x[y];
                Console.WriteLine(x[y]);
            }
        }
        public static void tenth(int[] x)
        {
            for(int y=0; y<x.Length; y++)
            {
                if(x[y]<0)
                {
                    x[y]=0;
                }
            Console.WriteLine(x[y]);
            }
            
        }
        public static void eleventh(int[] x)
        {
            int sum = 0;
            int av = 0;
            int min = 0;
            int max = 0;
            foreach (int num in x)
            {
                if(num>max)
                    max=num;
                else if (num<min)
                    min=num;
                
                sum += num;
            }
            av = sum/x.Length;
            int[] mma = new int[3];
            mma[0] = min;
            mma[1] = max;
            mma[2] = av;
            foreach (int num2 in mma)
            {
                Console.WriteLine(num2);
            }
            
        }
        public static void twelth(int[] x)
        {
            string[] newbie = new string[x.Length];
            for(int y=0; y<x.Length; y++)
            {
                if (x[y]<0)
                {
                    newbie[y]="Dojo";
                }
                else{
                    newbie[y]=x[y].ToString();
                }
                Console.WriteLine(newbie[y]);
            }
            
        }
    }
}
