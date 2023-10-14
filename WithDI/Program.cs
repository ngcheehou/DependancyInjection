using System;
using WithDI.Heroes;
using WithDI.Interfaces;
using WithDI.Inventories;

namespace WithDI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("");

            //Sword sword = new Sword();
            //Shield shield = new Shield();



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

            //SwordOfTheMorning swordOfTheMorning = new SwordOfTheMorning();
            //MagicFire Magicfire = new MagicFire();
            //MagicShield magicShield = new MagicShield();


            //Knight ArthurDayne = new Knight("Sir Arthur Dayne", swordOfTheMorning, shield);
            //Knight Melisandre = new Knight("Melisandre", Magicfire, magicShield);

            //while (ArthurDayne.HP > 0 && Melisandre.HP > 0)//pretends this is a game play
            //{
            //    int damage = ArthurDayne.Attack();
            //    Melisandre.Defend(damage);

            //    if (Melisandre.HP <= 0) continue;

            //    damage = Melisandre.Attack();
            //    ArthurDayne.Defend(damage);
            //}



            Console.WriteLine("");

            Sword sword = new Sword();
            Shield shield = new Shield();



            Knight Jamie = new Knight("Jamie The King Slayer", sword, shield);
            Knight Aerys = new Knight("Aerys II The Mad King", sword, shield);

            while (Jamie.HP > 0 && Aerys.HP > 0)//pretends this is a game play
            {
                int damage = Jamie.Attack();
                Aerys.Defend(damage);

                if (Aerys.HP <= 0) continue;

                damage = Aerys.Attack();
                Jamie.Defend(damage);
            }

            SwordOfTheMorning swordOfTheMorning = new SwordOfTheMorning();
            MagicFire Magicfire = new MagicFire();
            MagicShield magicShield = new MagicShield();


            Knight ArthurDayne = new Knight("Sir Arthur Dayne", swordOfTheMorning, shield);
            Knight Melisandre = new Knight("Melisandre", Magicfire, magicShield);

            while (ArthurDayne.HP > 0 && Melisandre.HP > 0)//pretends this is a game play
            {
                int damage = ArthurDayne.Attack();
                  damage = ArthurDayne.TagTeamAttack(Jamie);//Optional
                //Melisandre.Potion = new MagicPotion();//Optional
                
                Melisandre.Defend(damage);

                if (Melisandre.HP <= 0) continue;

                damage = Melisandre.Attack();
                ArthurDayne.Defend(damage);
            }

            Console.ReadLine();

             

        }
    }
}
