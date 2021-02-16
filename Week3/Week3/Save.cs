using System;
using System.IO;
using System.Threading;


namespace AdventureGame
{
    public class Save
    {
        public void SaveGame(Player player, string path)
        {
            Console.WriteLine("Test");

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

            }
        }

    }
    public void LoadGame(string path)
    {
        using (StreamReader sr = File.OpenText(path))
        {
  
            
  
        }
    }
}

