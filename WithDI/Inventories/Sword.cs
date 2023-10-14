using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDI.Interfaces;

namespace WithDI.Inventories
{
    public class Sword : IWeapon
    {
        public int Attack() => 70;
        
    }
}
