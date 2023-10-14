using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDI.Interfaces;

namespace WithDI.Heroes
{
    public class Magician : IHero
    {
        private IWeapon _weapon;
        private IShield _shield;

      

        public string Name { get; set; }
        public int HP { get; set; } = 100;

        public IPotion Potion { get; set; }

        public Magician(string name, IWeapon weapon, IShield shield)
        {
            Name = name;
            _weapon = weapon;
            _shield = shield;

        }

        public int Attack()
        {
            int damage = _weapon.Attack();
            Console.Write($"{Name} is attacking now, ");
            Console.WriteLine($"damage casted is {damage}");
            return damage;
        }


        public int FireBallAttack()
        {
            return 100;
        }
        public void Defend(int damage)
        {
            int actualDamage = damage - _shield.Defend();

            Console.WriteLine($"{Name} is taking damage {actualDamage}");

            if (actualDamage > 0)
                HP -= actualDamage;

            if (HP > 0)
            {
                Console.WriteLine($"{Name} remained {HP} HP ");
            }
            else
            {
                Console.WriteLine($"{Name} has fallen.");
            }



            if (Potion != null && HP > 0)
            {
                int healPoint = Potion.Heal();
                HP += healPoint;
                Console.WriteLine($"{Name}'s HP regenate {healPoint} points ");
                Console.WriteLine($"{Name} remained {HP} HP ");
            }

            Console.WriteLine();
        }
    }
}
