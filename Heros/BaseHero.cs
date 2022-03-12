namespace Raiding
{
    public abstract class BaseHero : IBaseHero , ICastAbilitable
    {
        protected BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name { get;}

        public int Power { get;}


        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }


    }
}
