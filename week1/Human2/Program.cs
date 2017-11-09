using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Paladin = new Human("Julie");
            Human human = new Human("Eric");

            Paladin.attack(human);
            Console.WriteLine($"The human {human.name} has a helath of {human.health} after the attack");
        }
    }
}
