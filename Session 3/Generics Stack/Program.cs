using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics_Stack
{
    static class Program
    {
        static void Main(string[] args)
        {
            var intStack = new Stack<int>();
            intStack.AddToStack(2, 3, 5);

            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());

            var stringStack = new Stack<string>();
            Add(stringStack, "one", "two", "three");

            Console.WriteLine(stringStack.Pop());
            Console.WriteLine(stringStack.Pop());
            Console.WriteLine(stringStack.Pop());
        }

        public static void Add<T>(Stack<T> stack, params T[] items)
        {
            foreach (var item in items)
            {
                stack.Push(item);
            }
        }


        public static void AddToStack<T>(this Stack<T> stack, params T[] items)
        {
            foreach (var item in items)
            {
                stack.Push(item);
            }
        }
    }
}