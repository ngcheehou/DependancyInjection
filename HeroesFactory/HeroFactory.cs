using HeroesFactory.Heroes;
using HeroesFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFactory
{
    public class HeroFactory
    {
        public  IHero CreateHero(int type, string name, IWeapon weapon, IShield shield = null)
        {
            switch (type)
            {
                case 1: return new Knight(name, weapon, shield);
                case 2: return new Magician(name, weapon, shield);
                default: throw new ArgumentException("Invalid hero type.");
            }
        }
    }
}
