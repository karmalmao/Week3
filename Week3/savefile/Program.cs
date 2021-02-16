using System;
using System.IO;

namespace savefile
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"c:\Users\s210193\Desktop\test.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(EHealth);
                    sw.WriteLine(PHealth);

                }
            }





        }
    }
}
