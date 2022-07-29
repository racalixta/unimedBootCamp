using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    //public sealed class Professor : Pessoa
    // acusará erro na classe que tentar ser filha de Professor


    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        //public sealed override void Apresentar()
        // acusará erro na classe que tentar sobreescrever o método Apresentar

        public override void Apresentar()
        {
            Console.WriteLine($"\nOlá, meu nome é {Nome}, tenho {Idade} anos e recebo R${Salario},00 \n");
        }
    }
}