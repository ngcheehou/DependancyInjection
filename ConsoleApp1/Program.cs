using ConsoleApp1.Hero;
using ConsoleApp1.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("");

            Sword sword = new Sword();
            Shield shield = new Shield();
           


            Knight knight1 = new Knight("Jamie", sword, shield);
            Knight knight2 = new Knight("Aerys II", sword, shield);

            while (knight1.HP > 0 && knight2.HP > 0)
            {
                int damage = knight1.Attack();
                knight2.Defend(damage);

                if (knight2.HP <= 0) continue;  

                damage = knight2.Attack();
                knight1.Defend(damage);
            }


            Console.ReadLine();
        }
    }
}
