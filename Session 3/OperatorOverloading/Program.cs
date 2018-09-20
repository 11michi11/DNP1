using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(12, 25);
            Time t2 = new Time(3, 15);
            Time t3 = t1 + t2;
            Console.WriteLine(t3.ToString());
        }
    }
}