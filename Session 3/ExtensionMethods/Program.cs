using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    static class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            numbers.AddAll(1, 2,3, 4, 5, 6, 7, 9);
            Console.WriteLine(numbers.GetRandomElement());
        }

        public static T GetRandomElement<T>(this List<T> list)
        {
            var rn = new Random();
            return list[rn.Next(0,list.Capacity)];
        }

        public static void AddAll<T>(this List<T> list, params T[] items)
        {
            foreach (var item in items)
            {
                list.Add(item);
            }
        }
    }
}