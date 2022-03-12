using System;
using System.Collections.Generic;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> heroes = new List<BaseHero>();

            Logic logic = new Logic();
            logic.LogicalFunction(n, heroes);

            int bossPower = int.Parse(Console.ReadLine());
            Result result = new Result();
            result.GetResult(heroes, bossPower);
        }
    }
}
