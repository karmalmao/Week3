using System;

namespace AdventureGame
{
    class Mage : Person
    {
        public Mage() : base()
        {
            item = "staff";
            name = "Mage";
            HP = 400;
            ATK = 300;
            DEF = 25;
            DROP = rand.Next(200, 500);
        }
        public override void Attack()
        {
            Console.WriteLine($"{name} casts firebolt at you with their {item}.");
        }
    }
}
