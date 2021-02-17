using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace fileio_test
{
    class contact
    {
        public float name2 = 0;
        public string name = "";
        public string email = "";
        public string phone = "";

        public contact()
        {

        }

        public contact(string name, string email, string phone)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public void Serialise(string filename)
        {
            using (StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine(name);
                sw.WriteLine(email);
            }
        }

        public void DeSerialise(string filename)
        {
            // TODO: use StreamReader to write the name, email and phone to file
        }

        public void Print()
        {
            Console.WriteLine($"{name} {email} {phone}");
        }
    }
}
