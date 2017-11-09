using System;
using System.Collections.Generic;

namespace Deck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck poker = new Deck();
            Player Eric = new Player("Eric");
            Player Julie = new Player("Julie");
            for(int i=1; i<=5; i++)
            {
                Eric.Draw(poker);
                Julie.Draw(poker);
            }
            Eric.Discard(2, poker);
            // Eric.Display();
            // int x=45;
            // while (x != 0)
            // {
            //     Console.WriteLine("Do you want to discard any cards (by Card #, 0 to exit)?:");
            //     string y = Console.ReadLine();
            //     x = Int64.TryParse(x);
            //     Console.WriteLine(x);
            //     if(x>0 && x<=5)
            //     {
            //         Eric.Discard(x, poker);
            //     }
            //     else
            //     {
            //         Console.WriteLine("That isn't a card");
            //     }
            // }
            Eric.Display();
            Julie.Display();
        }
    }
}
