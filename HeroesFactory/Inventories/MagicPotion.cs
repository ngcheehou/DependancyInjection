using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesFactory.Interfaces;

namespace HeroesFactory.Inventories
{

    public class MagicPotion : IPotion
    {
        public int Heal()
        {
            return 10;
        }
    }
}
