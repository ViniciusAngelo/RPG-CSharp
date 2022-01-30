namespace Projetos_C#.src.Entities
{
    public class BlackWizard : Hero
    {
            puclic BlackWizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }   
         puclic override string Attack()
        {
         return this.Name + "Lançou uma Magia Negra!";
        }
    }
}