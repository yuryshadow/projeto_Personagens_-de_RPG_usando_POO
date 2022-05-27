namespace projeto.src.Entities
{
    public class Ninja: Hero
    {
        public Ninja(string Name, int Level, string Herotype){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
            
        }

        public Ninja(){

        }

        public string Name;
        public int Level;
        public string HeroType;

        public string Attack(){
            return this.Name + " Atacou com uma shuriken";
        }
    }
}