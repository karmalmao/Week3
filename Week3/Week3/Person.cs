using System;

namespace AdventureGame
{
    public class Person
    {
        public Person()
        {

        }
        public Random rand = new Random();
        public string item = "";
        public string name = "";
        public float HP;
        public float ATK;
        public float DEF;
        public float DROP;
        public void displayItem(Array a)
        {
            Console.WriteLine($"{name} is holding {item}.");
        }
        public virtual void Attack()
        {
            Console.WriteLine($"{name} attacks you with their {item}.");
        }
    }
}
