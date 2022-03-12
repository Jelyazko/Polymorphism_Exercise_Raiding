using System;
using System.Collections.Generic;
namespace Raiding
{
    public class Logic
    {
        public void LogicalFunction(int n, List<BaseHero> heroes)
        {
            while (true)
            {
                string name = Console.ReadLine();
                string heroType = Console.ReadLine();

                try
                {
                    BaseHero hero = CreateHero.NewHero(heroType, name);
                    heroes.Add(hero);

                    if (heroes.Count == n) break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
