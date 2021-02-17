using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Numerics;


namespace AdventureGame
{
    public class Save
    {


        public void SaveGame(Player player , string path)
        {

            using (StreamWriter sw = File.CreateText(path))
            {
                
                sw.WriteLine(player.Pitem);
                sw.WriteLine(player.Pname);
                sw.WriteLine(player.PATK);
                sw.WriteLine(player.PDEF);
                sw.WriteLine(player.PHP);
                sw.WriteLine(player.IATK);
                sw.WriteLine(player.IDEF);
                sw.WriteLine(player.GOLD);
                Program.Sleep(0);
                Console.WriteLine("---------------");
                Console.WriteLine("Game saved!");
                Console.WriteLine("---------------");
                Program.Sleep(3000); 
            }
        }
        public void LoadGame(Player player , string path)
        {


            using (StreamReader sr = File.OpenText(path))
            {

                player.Pitem = sr.ReadLine();
                player.Pname = sr.ReadLine();
                player.PATK = float.Parse(sr.ReadLine());
                player.PDEF = float.Parse(sr.ReadLine());
                player.PHP = float.Parse(sr.ReadLine());
                player.IATK = float.Parse(sr.ReadLine());
                player.IDEF = float.Parse(sr.ReadLine());
                player.GOLD = float.Parse(sr.ReadLine());
                Program.Sleep(0);
                Console.WriteLine("---------------");
                Console.WriteLine("Game loaded!");
                Console.WriteLine("Check stats...");
                Console.WriteLine("---------------");
                Program.Sleep(3000);





            }

        }
    }

}

