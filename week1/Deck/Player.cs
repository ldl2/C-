using System;
using System.Collections.Generic;
namespace Deck
{
    public class Player
    {
        public string name;
        public List<Card> hand = new List<Card>();
        public Player(string _name)
        {
            name = _name;
        }

        public void Draw(Deck drawfrom)
        {
            hand.Add(drawfrom.Deal());
        }
        public void Display()
        {
            int i = 0;
            foreach (Card val in this.hand)
            {
                i++;
                Console.WriteLine("Card {0} for {1}: {2} of {3}", i, this.name, val.stringVal, val.suit );
            }
        }
        public List<Card> Discard(int i, Deck go)
        {
            this.hand.RemoveAt(i-1);
            this.Draw(go);
            return this.hand;
        }
        
    }
}
