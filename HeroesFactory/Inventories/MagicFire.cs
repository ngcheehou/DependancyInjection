using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesFactory.Interfaces;

namespace HeroesFactory.Inventories
{
    public class MagicFire : IWeapon
    {
        public int Attack() => 40;
    }
}
