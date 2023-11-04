using System;


namespace Interfaces
{
    class Dwarf : Unit
    {
        public Dwarf(IWeapon weapon) : base(weapon) 
        {
            _hp = 100;
            _damage = 25;
        }

        public override void Attack(IDamageable damageable)
        {
            Console.WriteLine("Dwarf attack");
            base.Attack(damageable);
        }

        protected override void Die()
        {
            Console.WriteLine("Dwarf was destroyed");
        }
    }
}
