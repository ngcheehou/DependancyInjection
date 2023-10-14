using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDI.Interfaces;

namespace WithDI.Inventories
{
    public class MagicShield: IShield
    {

        public int Defend()
        {
            Random random = new Random();
           
            if (random.Next(1, 101) > 70)//30% rate to get 1000 defence power
            {
                return 1000;
            }

            return 30;
        }
    }
}
