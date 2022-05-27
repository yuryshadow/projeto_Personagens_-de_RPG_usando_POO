using System;
using projeto.src.Entities;

namespace projeto{
    class Program
    {
        static void Main(string [] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight");
            WhiteWizard wizard = new WhiteWizard("Jennica", 23, "White Wizard");           
            
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));

        }
    }
}