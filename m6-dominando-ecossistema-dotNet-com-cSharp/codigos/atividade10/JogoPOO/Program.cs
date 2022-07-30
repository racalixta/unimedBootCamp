using System;
using JogoPOO.src.Entities;

namespace JogoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 12, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wizard.Attack(2));

        }
    }
}


