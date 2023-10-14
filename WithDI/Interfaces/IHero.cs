using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDI.Interfaces
{
    public interface IHero
    {
        string Name { get; set; }
        int HP { get; set; }

        int Attack();
        void Defend(int damage);
    }
}
