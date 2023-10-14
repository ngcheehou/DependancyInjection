using WithoutDI.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutDI.Heroes
{
    public class Knight
    {
        private Sword _sword;
        private SwordOfTheMorning _swordofthemorning;
        private Shield _shield;
        private MagicShield _magicShield;
        private MagicFire _magicFire;
     

        public string Name { get; set; }
        public int HP { get; private set; } = 100;

        public Knight(string name, Sword sword, Shield shield)
        {
            Name = name;
            _sword = sword;
            _shield = shield;
            
        }

        public Knight(string name, SwordOfTheMorning swordOfTheMorning, Shield shield)
        {
            Name = name;
            _swordofthemorning = swordOfTheMorning;
            _shield = shield;
             
        }

        public Knight(string name, MagicFire magicFire, MagicShield magicShield)
        {
            Name = name;
            _magicFire = magicFire;
            _magicShield = magicShield;

        }

        public int Attack()
        {
            int damage = _sword.Attack();
            Console.Write($"{Name} is attacking now, ");
            Console.WriteLine($"damage casted is {damage}");
            return damage;
        }

        public int AttackWithSwordOfTheMorning()
        {
            int damage = _swordofthemorning.Attack();
            Console.Write($"{Name} is attacking with Sword Of The Morning now, ");
            Console.WriteLine($"damage casted is {damage}");
            return damage;
        }

        public int AttackWithMagicFire()
        {
            int damage = _magicFire.Attack();
            Console.Write($"{Name} is attacking with Magic Fire now, ");
            Console.WriteLine($"damage casted is {damage}");
            return damage;
        }


        public void Defend(int damage)
        {
            int actualDamage = damage - _shield.Defend();

            Console.WriteLine($"{Name} is taking damage {actualDamage}");

            if(actualDamage>0)
            HP -= actualDamage;

            if (HP > 0)
            {
                Console.WriteLine($"{Name} remained {HP} HP ");
            }
            else
            {
                Console.WriteLine($"{Name} has fallen.");
            }

            Console.WriteLine();
        }

        public void DefendWithMagicSheild(int damage)
        {
            int actualDamage = damage - _magicShield.Defend();

            Console.WriteLine($"{Name} is taking damage {actualDamage}");

            if (actualDamage > 0)
            {
                HP -= actualDamage;
            }
            else
            {
                Console.WriteLine($"Magic Shield prevents {Name} from being hit!");
            }
                

            if (HP > 0)
            {
                Console.WriteLine($"{Name} remained {HP} HP ");
            }
            else
            {
                Console.WriteLine($"{Name} has fallen.");
            }

            Console.WriteLine();
        }
    }

}
