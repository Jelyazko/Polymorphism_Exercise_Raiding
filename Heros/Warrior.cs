namespace Raiding
{
    public class Warrior : BaseHero
    {
        private const int power = 100;

        public Warrior(string name)
            : base(name, power)
        {
        }
        public override string CastAbility()
            => $"{this.GetType().Name} - {this.Name} hit for {power} damage";

    }
}
