using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithoutDI.Heroes;
using WithoutDI.Inventories;

namespace WithoutDI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            Sword sword = new Sword();
            Shield shield = new Shield();



            //Knight Jamie = new Knight("Jamie The King Slayer", sword, shield);
            //Knight Aerys = new Knight("Aerys II The Mad King", sword, shield);

            //while (Jamie.HP > 0 && Aerys.HP > 0)//pretends this is a game play
            //{
            //    int damage = Jamie.Attack();
            //    Aerys.Defend(damage);

            //    if (Aerys.HP <= 0) continue;

            //    damage = Aerys.Attack();
            //    Jamie.Defend(damage);
            //}
            //Console.ReadLine();
            

            SwordOfTheMorning swordOfTheMorning = new SwordOfTheMorning();
            MagicFire Magicfire = new MagicFire();
            MagicShield magicShield = new MagicShield();
            

            Knight ArthurDayne = new Knight("Sir Arthur Dayne", swordOfTheMorning, shield);
            Knight Melisandre = new Knight("Melisandre", Magicfire, magicShield);

            while (ArthurDayne.HP > 0 && Melisandre.HP > 0)//pretends this is a game play
            {
                int damage = ArthurDayne.AttackWithSwordOfTheMorning();
                Melisandre.DefendWithMagicSheild(damage);

                if (Melisandre.HP <= 0) continue;

                damage = Melisandre.AttackWithMagicFire();
                ArthurDayne.Defend(damage);
            }


            Console.ReadLine();
        }
    }
}
