using System;

namespace FightGame2
{
    public class Weapon
    {
        public int minDamage = 10;
        public int maxDamage = 34;
        public string name;

        private Random generator = new Random();
        
        public int Attack()
        {
            return generator.Next(minDamage, maxDamage);
        }
    }
}