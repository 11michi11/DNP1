using System;

namespace Intro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John");
            john.Introduce();

            Console.WriteLine("Even numbers:");
            for (int i = 0; i <= 100; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);

            Console.WriteLine("Odd numbers:");
            int j = 0;
            while (j <= 100)
            {
                if (j % 2 == 1)
                    Console.WriteLine(j);
                j++;
            }
        }
    }
}
