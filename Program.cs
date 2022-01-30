using System; 
using Projetos_C#.src.Entities;

namespace Projetos_CS_
{
    class Program
    {
        static void Main(string[] args)
        {           
           Knight Arus = new Knight("Arus", 23,"Knight");
           Wizard Wizard = new Wizard("Jennica", 23, "White Wizard");
           Ninja Ninja = new Ninja("Wedge", 23, "Ninja");
           BlackWizard BlackWizard = new BlackWizard("Topapa", 23, "BlackWizard")

            Console.WriteLine(BlackWizard.Attack());
            Console.WriteLine(Ninja.Attack());
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Wizard.Attack());

        }
    }
}
