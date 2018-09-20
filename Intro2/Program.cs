using System;

namespace Intro2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter number between 0 and 10");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num) {
                case 0:
                    Console.WriteLine("This is the first number");
                    break;
                case 10:
                    Console.WriteLine("Thisi is the last number");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(num);
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}