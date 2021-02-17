using System;

namespace AdventureGame
{
    public class Player
    {
        public string Pitem = "";
        public string Pname = "";
        public float PHP;
        public float PATK;
        public float PDEF;
        public float IATK = 100;
        public float IDEF = 100;
        public float GOLD = 0;
        public void WChange(float a, string b)
        {
            IATK = a;
            Pitem = b;
        }
        public void AChange(float a)
        {
            IDEF = a;
        }
        public void Rest()
        {
            Program.Sleep(0);
            Console.WriteLine("You roll out your sleeping bag and take a long rest.");
            Program.Sleep(5000);
            Console.WriteLine("Resting...");
            Program.Sleep(5000);
            Console.WriteLine("You feel rested.");
            PHP = 500;
            Program.Sleep(0);
            Console.WriteLine("Your health has been restored!");
            Program.Sleep(2000);

        }
        public void Attack(Person a)
        {
            var name = a.name;
            Console.WriteLine($"You attack {name} with {Pitem}");
            Console.WriteLine("---------------");
        }
        public void ViewInv(string a)
        {
            string ok = "";
            if (a != "stats")
            {
                Console.WriteLine("Cannot view inventory now"); // not implemented
            }
            else
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine($"Gold = {GOLD}");
                Console.WriteLine($"Health = {PHP}");
                Console.WriteLine($"Attack = {PATK}");
                Console.WriteLine($"Defense = {PDEF}");
                Console.WriteLine($"Weapon = {Pitem}");
                Console.WriteLine("--------------------");
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
                //show stats here
            }
        }
        public Player()
        {
            Pitem = "Longsword";
            Pname = "Player";
            PHP = 500;
            PATK = IATK + 25;
            PDEF = IDEF + 25;
        }
    }
}
