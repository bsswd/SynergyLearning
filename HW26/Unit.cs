using System;

namespace Interfaces
{
    class Unit : IDamageable, IMovable
    {
        protected int _hp;
        protected int _damage;

        protected IWeapon _weapon;

        public Unit(IWeapon weapon) => _weapon = weapon; 

        public virtual void Attack(IDamageable damageable)
        {
            _weapon.Use();
            damageable.TakeDamage(_damage);
        }

        public virtual void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentException("Damage must be higher than zero");

            if (damage >= _hp)
            {
                _hp = 0;
                Die();
                return;
            }
            _hp -= damage;
        }

        public void Move(Point position)
        {
            Console.WriteLine($"Character move to position: {position}");
        }


        protected virtual void Die() {}
    }
}
