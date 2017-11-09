using System;
using System.Collections.Generic;

namespace Human
{
    public class Samurai : Human
    {
        public Samurai(string _name) : base(_name)
        {
            health=200;
        }

    
        public void death_blow(object thing)
            {
                Human enemey = thing as Human;
                if(enemey == null)
                {
                    Console.WriteLine("Failed Attack");
                }
                else
                {
                    if (enemey.health<50)
                        {
                        enemey.health = 0;
                        }
                }
            }
        public void meditate()
        {
            this.health = 200;
        }
    }
}