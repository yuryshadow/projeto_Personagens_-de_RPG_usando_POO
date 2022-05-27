namespace projeto.src.Entities
{
    public class Ninja: Hero
    {
        public Ninja(string Name, int Level){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = "Ninja";
            
        }

        public Ninja(){

        }

        public string Name;
        public int Level;
        public string HeroType;

        public string Attack(int Bonus){

            if(Bonus > 6){
                return this.Name + " Atacou com uma shuriken";
            }else{
                return this.Name + " Atacou com o jutsu clone das sombras";
            }
        }
    }
}