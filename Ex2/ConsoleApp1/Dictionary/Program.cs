using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> nicknames = new Dictionary<string,Person>();
            Person johnatan = new Person("Johnatan", 20, 9001);
            nicknames["john"] = johnatan;
            Console.WriteLine(nicknames["john"]);
        }
    }
}