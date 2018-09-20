using System;

namespace MethodOverloading
{
    public class Player
    {
        public void Shout(string text)
        {
            Console.WriteLine($"{text.ToUpper()}!");
        }

        public void Shout(int luckyNumber)
        {
            Console.WriteLine($"{luckyNumber} is my lucky number");
        }

        public void Shout(Enemy enemy)
        {
            Console.WriteLine($"The damage this enemy can do to me is {enemy.GetDmg()}");
        }
        
    }
}