using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.IO;

namespace AdventureGame
{
    class Program
    {


        public static Person[] persons = new Person[21];
        public static void Main(string[] args)
        {
            persons[0] = new Grunt();
            persons[1] = new Brute();
            persons[2] = new Mage();
            persons[3] = new Grunt();
            persons[4] = new Brute();
            persons[5] = new Mage();
            persons[6] = new Grunt();
            persons[7] = new Brute();
            persons[8] = new Mage();
            persons[9] = new Grunt();
            persons[10] = new Brute();
            persons[11] = new Mage();
            persons[12] = new Grunt();
            persons[13] = new Brute();
            persons[14] = new Mage();
            persons[15] = new Grunt();
            persons[16] = new Brute();
            persons[17] = new Mage();
            persons[18] = new Grunt();
            persons[19] = new Brute();
            persons[20] = new Boss();

            var r = new Random();
            bool startable = true;
            string state = "start";
            bool menu = false;
            string savePath = @".\save.sav";
            Save save = new Save();
            Save load = new Save();
            var player = new Player();

            while (startable == true)
            {
                Console.WriteLine("Welcome to some random adventure game!");
                startable = false;
                menu = true;
                Sleep(2000);
                while (menu)
                {
                    menu = false;
                    Console.Clear();
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("stats, fight, rest, shop, save, load");
                    state = Console.ReadLine();
                    state.ToLower();
                    if (state != "stats" && state != "fight" && state != "rest" && state != "shop" && state != "save" && state != "load")
                    {
                        Sleep(1000);
                        Console.WriteLine("Not a Valid Command");
                        Sleep(1000);
                        Console.WriteLine("Restarting...");
                        Sleep(1000);
                        startable = true;
                        menu = true;
                    }
                    else
                    {
                        if (state == "stats")
                        {
                            state = null;
                            player.ViewInv("stats");
                            menu = true;
                        }
                        if (state == "fight")
                        {
                            var e = r.Next(0, persons.Length);
                            Console.WriteLine($"You initialise combat with {persons[e].name}");
                            Console.Clear();
                            if (persons[e].name == "The Beholder")
                            {
                                Console.WriteLine("You encounter the boss!");
                                Console.WriteLine("Defeat this to beat the game!");
                            }
                            while (player.PHP > 0 && persons[e].HP > 0)
                            {
                                Console.WriteLine("---------------");
                                persons[e].Attack();
                                var dmg = r.Next(0, (int)persons[e].ATK - (int)player.IDEF);
                                Console.WriteLine("---------------");
                                Console.WriteLine($"You take {dmg} damage.");
                                Console.WriteLine("---------------");
                                player.PHP = player.PHP - dmg;
                                Console.WriteLine($"Your HP is now {player.PHP}");
                                Console.WriteLine("---------------");
                                Thread.Sleep(500);
                                player.Attack(persons[e]);
                                Thread.Sleep(500);
                                var admg = r.Next(0, (int)player.PATK - (int)persons[e].DEF);
                                Thread.Sleep(500);
                                Console.WriteLine($"You attack {persons[e].name} for {admg}");
                                Thread.Sleep(500);
                                Console.WriteLine("---------------");
                                Thread.Sleep(500);
                                persons[e].HP = persons[e].HP - admg;
                                Console.WriteLine($"Enemys HP is now {persons[e].HP}");
                                Thread.Sleep(500);
                            }
                            if (player.PHP <= 0)
                            {
                                Console.WriteLine("You died!");
                                Console.WriteLine($"Cause of death: {persons[e]}");
                                menu = true;
                                state = null;
                            }
                            if (persons[e].HP <= 0)
                            {
                                Console.WriteLine($"You defeated {persons[e]}!");
                                player.GOLD = player.GOLD + persons[e].DROP;
                                Console.WriteLine($"Your current gold is {player.GOLD}!");
                                Console.WriteLine("Press a key to continue!");
                                Console.ReadLine();
                                menu = true;
                                state = null;
                            }
                            if (persons[e].name == "The Beholder" && persons[e].HP <= 0)
                            {
                                Console.WriteLine("Congrats! You beat the game!");
                                Console.WriteLine("Your stats have been maxed");
                                Console.ReadKey();
                                player.PHP = 1000000;
                                player.PATK = 1000000;
                                player.PDEF = 1000000;
                                player.GOLD = 1000000;
                                menu = true;
                                state = null;
                            }

                        }
                        if (state == "rest")
                        {
                            player.Rest();
                            state = null;
                            menu = true;
                        }
                        while (state == "shop")
                        {
                            Sleep(0);
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("           SHOP           ");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Longsword - Free");
                            Console.WriteLine("Greatsword - 500 Gold"); // greatsword stats : defeats grunts
                            Console.WriteLine("Hugesword - 1000 Gold"); // hugesword stats : defeats mages
                            Console.WriteLine("Massivesword - 2000 Gold"); // massivesword stats : defeats brutes
                            Console.WriteLine("Giganticsword - 5000 Gold"); // giganticsword stats : 1 shot everything
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("");
                            Console.WriteLine($"Your gold is {player.GOLD}");
                            Console.Write("What would you like to do?");

                            var buy = Console.ReadLine();
                            buy.ToLower();
                            if (buy != "longsword" && buy != "greatsword" && buy != "hugesword" && buy != "massivesword" && buy != "giganticsword")
                            {
                                Sleep(0);
                                Console.WriteLine("Not a valid command");
                                Sleep(500);
                                Console.WriteLine("Restarting...");
                                Sleep(500);
                                state = "shop";
                                menu = true;

                            }
                            else
                            {
                                if (buy == "longsword")
                                {
                                    Console.WriteLine("You already own this!");
                                }
                                if (buy == "greatsword" && player.GOLD >= 500)
                                {
                                    player.GOLD = player.GOLD - 500;
                                    player.WChange(50);
                                }
                                if (buy == "hugesword")
                                {

                                }
                                if (buy == "massivesword")
                                {

                                }
                                if (buy == "giganticsword")
                                {

                                }
                                else
                                {

                                }
                                state = null;
                            }
                        }

                        if (state == "save")
                        {
                            save.SaveGame(player, savePath);
                            state = null;
                            menu = true;
                        }
                        if (state == "load")
                        {
                            //  save.LoadGame();
                            state = null;
                        }
                    }
                }














            }
           
        }
        public static void Sleep(int a)
            {
                Thread.Sleep(a);
                Console.Clear();
            }
    }
}
