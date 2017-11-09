using System.Collections.Generic;
namespace Deck
{
    public class Card
    {
        public int[] AllowedVal = new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13};
        public int val;
        
        public string suit;
        public string stringVal;
    public Card(string _suit, int _val)
    {
        int Counter = 0;
        foreach (int value in AllowedVal)
        {
            if(value == _val)
            {
                val = _val;
            }
            else
            {
                Counter++;
            }
            if(Counter>12)
            {
                System.Console.WriteLine("Choose a value between 1-13!");
                val =2000;
            }
        }

        if("Spades" == _suit)
        {
            suit = _suit;
        }
        else if ("Clubs" ==_suit)
        {
            suit = _suit;
        }
        else if ("Hearts" ==_suit)
        {
            suit = _suit;
        }
        else if ("Diamonds" ==_suit)
        {
            suit = _suit;
        }
        else{
            System.Console.WriteLine("Choose one of Spades, Clubs, Hearts, or Diamonds");
            suit = "None";
        }

        if (val<11 && val>1)
        {
            stringVal = val.ToString();
        }
        else if (val == 2000){
            stringVal="None";
        }
        else if (val == 1)
        {
            stringVal = "Ace";
        }
        else if (val == 11)
        {
            stringVal = "Jack";
        }
        else if (val == 12)
        {
            stringVal = "Queen";
        }
        else if (val == 13)
        {
            stringVal = "King";
        }
    }
    }
    
}