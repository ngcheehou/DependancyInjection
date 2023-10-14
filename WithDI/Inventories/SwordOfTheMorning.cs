using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDI.Interfaces;

namespace WithDI.Inventories
{
    public class SwordOfTheMorning : IWeapon
    {

        public int Attack()
        { 
            Random random = new Random();
            if (random.Next(1, 101) > 70)//30% rate to get high damage 
            {
                Console.WriteLine("Sword of the morning cast critical damage!!!");
                return 100;
            }
            return 50;
        }
    }
}
