using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            var now = DateTime.Now;
            schedule[now] = "DNP";
            
            Console.WriteLine(schedule[now]);
            
        }
    }
}