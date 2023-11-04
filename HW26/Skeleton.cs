using System;


namespace Interfaces
{
    class Skeleton : Unit
    {
        public Skeleton(IWeapon weapon) : base(weapon)
        {
            _hp = 15;
            _damage = 10;
        }

        public override void Attack(IDamageable damageable)
        {
            Console.WriteLine("Skeleton attack");
            base.Attack(damageable);
        }

        protected override void Die()
        {
            Console.WriteLine("Skeleton was destroyed");
        }

    }
}
