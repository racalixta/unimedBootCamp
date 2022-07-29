using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"\nOlá, meu nome é {Nome}, tenho {Idade} anos e tirei {Nota} na prova\n");
        }
    }
}