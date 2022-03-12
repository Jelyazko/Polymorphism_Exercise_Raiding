using System;
using System.Collections.Generic;
namespace Raiding
{
    public class Result
    {
        public void GetResult(List<BaseHero> heroes, int bossPower)
        {
            int castAbility = 0;
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                castAbility += (hero.Power);

            }
            if (bossPower <= castAbility) Console.WriteLine("Victory!");
            else Console.WriteLine("Defeat...");
        }
    }
}
