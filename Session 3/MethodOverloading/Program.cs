using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player john = new Player();
            john.Shout("DIE!");
            john.Shout(5);
            john.Shout(new Enemy(20));
        }
    }

    public class Enemy
    {
        private int damage;

        public Enemy(int damage)
        {
            this.damage = damage;
        }

        public int GetDmg()
        {
            return damage;
        }
    }
}