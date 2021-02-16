namespace AdventureGame
{
    class Grunt : Person
    {
        public Grunt() : base()
        {
            item = "axe";
            name = "Grunt";
            HP = 400;
            ATK = 200;
            DEF = 50;
            DROP = rand.Next(100, 300);
        }
    }
}
