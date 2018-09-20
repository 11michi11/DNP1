using System;

namespace Delegate
{
    class Program
    {
        public delegate void Notifier(string message);
        
        
        static void Main(string[] args)
        {
            Notifier notifier = SayHello;
            notifier += SayGoodbye;

            notifier("John");
        }

        public static void SayHello(string name) => Console.WriteLine($"Hello {name}");
        public static void SayGoodbye(string name) => Console.WriteLine($"Goodbye  {name}");
    }
}