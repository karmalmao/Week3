using System;
using System.Threading;
using System.Globalization;

namespace inheritance
{
    class Program
    {
        public static Person[] persons = new Person[3];
        public static void Main(string[] args)
        {
            persons[0] = new Grunt();
            persons[1] = new Brute();
            persons[2] = new Mage();

            bool able = true;
            int state = 1;
            string test = "";
            string again = "";

            while (able)
            {
                if (state == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You are approached by a Mage, Brute, and Grunt");
                    Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("What will you do? ");
                    state = 2;
                    while (state == 2)
                    {
                        test = Console.ReadLine();
                        test.ToLower();
                        able = false;
                        if (test == "fight")
                        {
                            Console.Clear();
                            Console.WriteLine("You engage in combat with the enemies");
                            Sleep(2000);
                            Console.Clear();
                            state = 4;
                        }
                        if (test == "run" || test == "flee")
                        {
                            Console.Clear();
                            Console.WriteLine("You flee from the scene");
                            Sleep(3000);
                            Console.Clear();
                            Console.WriteLine("Coward");
                            Sleep(300);
                            Console.Clear();
                            state = 3;
                        }
                    }
                    if (state == 4)
                    {
                        Console.WriteLine("You are now fighting the enemies");
                        Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("You are not strong enough to take 3 enemies");
                        Sleep(2000);
                        Console.Clear();
                        foreach (var p in persons) { p.Attack(); Console.WriteLine("");  Sleep(2000); }
                        Console.WriteLine("You died");
                    }
                    if (state == 3)
                    {
                        Console.WriteLine("The enemies start to chase you.");
                        Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("You cannot escape from the enemies");
                        Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("You are now fighting the enemies");
                        Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("You are not strong enough to take 3 enemies");
                        Sleep(2000);
                        Console.Clear();
                        foreach (var p in persons) { p.Attack(); Console.WriteLine(""); Sleep(2000); }
                        Console.Clear();
                        Console.WriteLine("You died");
                        Sleep(2000);
                    }
                    Console.WriteLine("Would you like to try again? ");
                    again = Console.ReadLine();
                    again.ToLower();
                    if (again == "yes") {able = true; state = 1;}
                else able = false;



                }
                


            }
            
            
            
            
            
            
            
           


        }
        public static void Sleep(int a)
        {
            Thread.Sleep(a);
        }
    }
    class Person
    {
        public string item = "";
        public string name = "";

        public void displayItem(Array a)
        {
            Console.WriteLine($"{name} is holding {item}.");
        }
       public virtual void Attack()
        {
            Console.WriteLine($"{name} attacks you with their {item}.");
        }
    }
    class Grunt : Person
    {
        public Grunt() : base()
        {
            item = "axe";
            name = "Grunt";
        }
    }
    class Brute : Person
    {
       public Brute() : base()
        {
            item = "hammer";
            name = "Brute";
        }
    }
    class Mage : Person
    {
        public Mage() : base()
        {
            item = "staff";
            name = "Mage";
        }
        public override void Attack()
        {
            Console.WriteLine($"{name} casts firebolt at you with their {item}.");
        }
    }

}
