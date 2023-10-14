using ConsoleApp1.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hero
{
    public class Knight
    {
        private Sword _sword;
        private Shield _shield;
        

        public string Name { get; set; }
        public int HP { get; private set; } = 100;

        public Knight(string name, Sword sword, Shield shield)
        {
            Name = name;
            _sword = sword;
            _shield = shield;
             
        }

        public int Attack()
        {
            int damage = _sword.Attack();
            Console.Write($"{Name} is attacking now, ");
            Console.WriteLine($"damage casted is {damage}");
            return damage;
        }

        public void Defend(int damage)
        {
            int actualDamage = damage - _shield.Defend();

            Console.WriteLine($"{Name} is taking damage {actualDamage}");
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
    }

}
