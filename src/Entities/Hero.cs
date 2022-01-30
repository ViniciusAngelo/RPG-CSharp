namespace Projetos_C#.src.Entities
{
    public abstract class Hero
    {
       public Hero(string Name, int level, string HeroType){
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
       }

       puclic Hero (){


       }

       puclic string Name;

       puclic int level;
       
       public string HeroType;

       puclic override string ToString(){
         return this.Name + " " + this.level + " " + this.HeroType;
       }

       puclic virtual string Attack(){
           return this.Name + "Atacou com a sua espada!";
       }
    }
}