namespace Projetos_C#.src.Entities
{
    public class Wizard : Hero
    {
        puclic Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
            puclic override string Attack()
            {
              return this.Name + "Lançou magia!";
            } 

       puclic string Attack(int Bonus){

           if(Bonus > 6)
           {
            return this.Name + "Lançou magia super efetiva com bonus de" + Bonus; 
           }
           else{
            return this.Name + "Lançou uma magia fraca com bonus de" + Bonus;
           }
  
       }
    }
}