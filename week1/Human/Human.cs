namespace Human
{
    public class Human
    {
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;
        public string name;

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
        public void attack(Human thing)
        {
            thing.health -= (5 * strength);
        }
    }
}