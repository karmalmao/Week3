using System;
using System.IO;

namespace fileio_test
{
    class Program
    {
        static void Main(string[] args)
        {
            contact person1 = new contact("bob", "bob@email.com", "12345678");
            contact person2 = new contact("fred", "fred@email.com", "12345678");
            contact person3 = new contact("ted", "ted@email.com", "12345678");

            // write each contact to file
            person1.Serialise("./contacts/bob.txt");
            person2.Serialise("./contacts/fred.txt");
            person3.Serialise("./contacts/ted.txt");


            // lets clear out the "contact" and load it back in from file
            person1 = new contact();
            person2 = new contact();
            person3 = new contact();

            person1.DeSerialise("./contacts/bob.txt");
            person2.DeSerialise("./contacts/fred.txt");
            person3.DeSerialise("./contacts/ted.txt");

            person1.Print();
            person2.Print();
            person3.Print();
        }
    }
}
