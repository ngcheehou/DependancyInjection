using HeroesFactory.Heroes;
using HeroesFactory.Interfaces;
using HeroesFactory.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory");

            Sword sword = new Sword();
            Shield shield = new Shield();



            HeroFactory heroFactory = new HeroFactory();


            //Knight Jamie = new Knight("Jamie The King Slayer", sword, shield);
            //Knight Aerys = new Knight("Aerys II The Mad King", sword, shield);

            IHero Jamie = heroFactory.CreateHero(1, "Jamie The King Slayer", sword, shield);
            IHero Aerys = heroFactory.CreateHero(1, "Aerys II The Mad King", sword, shield);

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


            //Knight ArthurDayne = new Knight("Sir Arthur Dayne", swordOfTheMorning, shield);
            //Knight Melisandre = new Knight("Melisandre", Magicfire, magicShield);
            IHero ArthurDayne = heroFactory.CreateHero(1, "Sir Arthur Dayne", swordOfTheMorning, shield);
            IHero Melisandre = heroFactory.CreateHero(2, "Melisandre", Magicfire, magicShield);

            while (ArthurDayne.HP > 0 && Melisandre.HP > 0)//pretends this is a game play
            {

                int damage = ArthurDayne.TagTeamAttack(Jamie);//Optional
                Melisandre.Potion = new MagicPotion();

                Melisandre.Defend(damage);

                if (Melisandre.HP <= 0) continue;

                damage = Melisandre.Attack();
                ArthurDayne.Defend(damage);
            }

            Console.ReadLine();
        }
    }
}
