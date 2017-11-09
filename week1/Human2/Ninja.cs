using System;
using System.Collections.Generic;
namespace Human
{
    public class Ninja: Human
    {
        public Ninja(string _name) : base(_name)
        {
            dexterity=175;
        }
        public void steal(object thing)
        {
            attack(thing);
            this.health +=10;
        }
        public void get_away()
        {
            this.health -= 15;
        }
    }
}