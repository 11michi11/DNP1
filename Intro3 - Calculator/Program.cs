using System;
using System.Text;

namespace Intro3 {
    class Program {
        static void Main (string[] args) {

            // Console.WriteLine(MathLib.Calculator.Add(new int[] {1, 32, 3}));
            // Console.WriteLine(MathLib.Calculator.Max(1, 2));
            Console.Write ("Enter your name: ");
            var name = Console.ReadLine ();
            char[] nameChars = new char[name.Length];

            for (int i = 0; i < name.Length; i++)
                nameChars[i] = name[i];

            Array.Reverse(nameChars);
            string reversed = new string(nameChars);
            Console.WriteLine(reversed);
        }
    }
}