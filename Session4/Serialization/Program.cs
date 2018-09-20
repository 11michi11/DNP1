using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person("John", "Smith", 266666);
            
//            Serialize(john);
            var johnIsBack = Deserialize();
            Console.WriteLine(johnIsBack.FirstName);
            Console.WriteLine(johnIsBack.LastName);
            Console.WriteLine(johnIsBack.Ssn);
        }

        public static void Serialize(Person person)
        {
            IFormatter formatter = new BinaryFormatter();  
            Stream stream = new FileStream("person.bin", FileMode.Create, FileAccess.Write, FileShare.None);  
            formatter.Serialize(stream,person);  
            stream.Close();  
        }

        public static Person Deserialize()
        {
            IFormatter formatter = new BinaryFormatter();  
            Stream stream = new FileStream("person.bin", FileMode.Open, FileAccess.Read, FileShare.Read);  
            Person obj = (Person) formatter.Deserialize(stream);  
            stream.Close();
            return obj;
        }
    }
}