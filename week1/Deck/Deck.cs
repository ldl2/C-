using System;
using System.Collections.Generic;

namespace Deck
{
    public class Deck
    {
        public List<Card> outCards = new List<Card>();
        public List<Card> Cards = new List<Card>(52);
        private string[] suits= {"Spades", "Clubs", "Diamonds", "Hearts"};
        public Deck()
        {
            for(int i=1; i<=13; i++)
            {
                foreach (string suity in suits)
                {
                    Card a = new Card(_suit: suity, _val: i);
                    this.Cards.Add(a);
                }
            }
            Shuffle();
        }
        
        
        

        //method returns a card takes in list of cards and use our list
        public Card Deal()
        {
            //sets a card so can see after removed
            //must set as card object so it returns right
            Card Delt = this.Cards[0];
            //removes
            outCards.Add(Delt);
            this.Cards.RemoveAt(0);
            //returns saved value
            return Delt;
        }
        public Deck reset()
        {
            foreach(Card used in outCards)
            {
                this.Cards.Add(used);
            }
        return this;
        }
        public Deck Shuffle()
        {
            int len = this.Cards.Count/2;
            Random random = new Random();
            for (int wordspot = 0; wordspot<len; wordspot++)
            {
                int rndnum = wordspot + random.Next(len);
                var tmp = this.Cards[rndnum];
                this.Cards[rndnum] = this.Cards[wordspot];
                this.Cards[wordspot] = tmp;
            }
            return this;
        }
    }
}