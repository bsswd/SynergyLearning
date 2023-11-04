using System;

namespace Interfaces
{
    class Wall : IDamageable
    {
        public void Attack(IDamageable damageable) { }

        public void TakeDamage(int damage)
        {
            Console.WriteLine("Wall destroyed");
        }
    }
}
