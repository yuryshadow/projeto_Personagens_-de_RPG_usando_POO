namespace projeto.src.Entities
{
    public class Knight: Hero
    {
         public Knight(string Name, int Level){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = "Knight";
        }

        public Knight(){
            
        }



        public string Attack(){
            return this.Name + " Atacou com a sua espada";
        }

         public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

    }
}