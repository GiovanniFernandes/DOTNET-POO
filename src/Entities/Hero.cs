namespace DOTNET_POO.src.Entities
{
    public abstract class Hero
    {
        //  atalhos uteis do IntelliSense para classes: prop, ctor

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Hero()
        {
            
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return $"Eu sou {this.Name}, um {this.HeroType} level {this.Level}";
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com sua espada!";
        }
    }
}