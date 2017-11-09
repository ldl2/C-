using System;
using System.Collections.Generic;
namespace Human
{
    public class Wizard : Human
    {
        public Wizard(string _name) : base(_name)
        {
            intelligence = 25;
            health = 50;
            name = _name;
        }
        public void Heal()
        {
            this.health += 10 * this.intelligence;
            if (this.health > 50)
            {
                this.health = 50;
            }
        }
        public void fireball(object thing)
        {
            Random num = new Random();
            int flame = num.Next(20,50);

            Human enemey = thing as Human;
            if(enemey == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemey.health -= flame;
            }
        }
    }
}