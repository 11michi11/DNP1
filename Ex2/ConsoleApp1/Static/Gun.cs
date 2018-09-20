using System;

namespace Static
{
    public class Gun
    {
        private static int gunCount = 0;
        private static int bulletCount = 0;
        private int shotsFired = 0;

        public Gun()
        {
            gunCount++;
        }

        public void Shoot()
        {
            Console.WriteLine("BANG!");
            bulletCount++;
            shotsFired++;
        }

        public int GetBulletCount()
        {
            return bulletCount;
        }

        public int GetShotsFired()
        {
            return shotsFired;
        }
    }
}