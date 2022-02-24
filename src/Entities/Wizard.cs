namespace DOTNET_POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return $"{this.Name} usou sua magia!";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6) return $"{this.Name} usou sua magia super efetiva com bônus de +{Bonus} de dano!";
            else return $"{this.Name} usou sua magia fraca com bônus de +{Bonus} de dano!";
        }

        //  Attack() tem sobrecarga de método, pois tem mais de um método com o msm nome e parâmetros diferentes
    }
}