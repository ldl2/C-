using System;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> Empty = new List<object>();
            Empty.Add(7);
            Empty.Add(28);
            Empty.Add(-1);
            Empty.Add(true);
            Empty.Add("chair");

            int sum = 0;

            foreach (object thing in Empty){
                
                if(thing is int){
                    Console.WriteLine(thing);
                    sum += (int)thing;
                }
                else if(thing is bool){
                    Console.WriteLine(thing);
                }
                else if(thing is String){
                    Console.WriteLine(thing);
                }
                else{
                    Console.Write(thing);
                }
            }
        Console.WriteLine(sum);
        }
    }
}
