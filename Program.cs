using System;
using projeto.src.Entities;

namespace projeto{
    class Program
    {
        static void Main(string [] args)
        {
            Knight knight = new Knight("Arus", 23);
            Ninja ninja = new Ninja("Wedge", 25);
            WhiteWizard whwizard = new WhiteWizard("Jennica", 23);  
            BlackWizard bwizard = new BlackWizard("Topapa", 30);         
            
            Console.WriteLine(knight.HeroType);

        }
    }
}