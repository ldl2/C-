using System;
using System.Collections.Generic;
namespace Human
{
    public class Human
    {
        public int strength {get; set;}
        public int intelligence {get; set;}
        public int dexterity {get; set;}
        public int health {get; set;}
        public string name {get; set;}

        public Human(string _name)
        {
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
            name = _name;
        }
        public Human(string _name, int _str, int _dex, int _int, int _health)
        {
            strength = _str;
            intelligence = _int;
            dexterity = _dex;
            health = _health;
            name = _name;
        }
        public void attack(object thing)
        {
            Human enemey = thing as Human;
            if(enemey == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemey.health -= (5 * strength);
            }
        }
    }
}