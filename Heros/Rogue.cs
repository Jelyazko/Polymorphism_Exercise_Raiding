namespace Raiding
{
    public class Rogue : BaseHero
    {
        private const int power = 80;

        public Rogue(string name)
            : base(name, power)
        {
        }

        public override string CastAbility()
             => $"{this.GetType().Name} - {this.Name} hit for {power} damage";

    }
}
