using System;

namespace AdventureGame
{
    class Boss : Person
    {
        public Boss() : base()
        {
            item = "staff";
            name = "The Beholder";
            HP = 5;
            ATK = 500;
            DEF = 25;
            DROP = rand.Next(200, 500);
        }
        public override void Attack()
        {
            Console.WriteLine($"{name} casts firebolt at you with their {item}.");
        }
    }
}
