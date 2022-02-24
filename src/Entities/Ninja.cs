namespace DOTNET_POO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return $"{this.Name} arremessou uma shuriken!";
        }

        public string Attack(int bonus)
        {
            if(bonus > 6) return $"{this.Name} arremesou a shuriken num ponto letal do oponente, causando +{bonus} de dano!";
            else return $"{this.Name} arremessou uma shuriken e causou +{bonus} de dano!!";
        }
    }
}