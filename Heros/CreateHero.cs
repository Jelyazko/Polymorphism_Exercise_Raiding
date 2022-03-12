namespace Raiding
{
    public class CreateHero
    {
        public static BaseHero NewHero(string heroType, string name)
        {
            BaseHero baseHero;
            switch (heroType)
            {
                case "Druid":
                    baseHero = new Druid(name);
                    break;
                case "Paladin":
                    baseHero = new Paladin(name);
                    break;
                case "Rogue":
                    baseHero = new Rogue(name);
                    break;
                case "Warrior":
                    baseHero = new Warrior(name);
                    break;
                default:
                    throw new System.ArgumentException("Invalid hero!");
            }
            return baseHero;
        }
    }
}
