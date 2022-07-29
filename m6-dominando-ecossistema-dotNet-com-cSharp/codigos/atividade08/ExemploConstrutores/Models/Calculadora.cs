using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{   

    public class Calculadora
    {
        // Delegate
        public delegate void DelegateCalculadora();

        // Event
        public static event DelegateCalculadora EventoCalculadora;


        public static void Somar(int x, int y)
        {
            if(EventoCalculadora != null)
            {
                Console.WriteLine($"\nAdição: {x + y}\n");
                EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("\nNenhum inscrito\n");
            }
        }

        public static void Subtrair(int x, int y)
        {
            Console.WriteLine($"\nSubtração: {x - y}\n");
        }
    }
}