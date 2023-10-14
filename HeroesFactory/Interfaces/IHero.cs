using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFactory.Interfaces
{
    public interface IHero
    {
        string Name { get; set; }
        int HP { get; set; }
        IPotion Potion { get; set; }

        int Attack();
        int TagTeamAttack(IHero hero);
        void Defend(int damage);
    }
}
