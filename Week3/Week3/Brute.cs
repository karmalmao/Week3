namespace AdventureGame
{
    class Brute : Person
    {
        public Brute() : base()
        {
            item = "hammer";
            name = "Brute";
            HP = 1000;
            ATK = 250;
            DEF = 100;
            DROP = rand.Next(300, 600);
        }
    }
}
