namespace projeto.src.Entities
{
    public class Knight: Hero
    {
         public Knight(string Name, int Level, string Herotype){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
        }

        public Knight(){
            
        }

        public string Name;
        public int Level;
        public string HeroType;

        public string Attack(){
            return this.Name + " Atacou com a sua espada";
        }

    }
}