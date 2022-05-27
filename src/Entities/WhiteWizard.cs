namespace projeto.src.Entities
{
    public class WhiteWizard : Hero
    {

        public WhiteWizard(string Name, int Level)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = "WhiteWizard";
        }
        public override string Attack(){
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus){
        
            if(Bonus > 6){
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }else{
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
            
        }
    }
}