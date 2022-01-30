namespace Projetos_C#.src.Entities
{
    public class Ninja : Hero
    {
           puclic Ninja(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        } 
        puclic override string Attack()
        {
         return this.Name + "Lançou uma Adaga!";
        }
}