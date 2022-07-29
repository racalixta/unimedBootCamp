using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        // private readonly string nome = "John";
        // private readonly string sobrenome;
        private string nome;
        private string sobrenome;



        // public Pessoa()
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;
        // }


        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("\nConstrutor classe Pessoa\n");
        }

        public void Apresentar()
        {
            //this.nome = "teste do readonly";
            Console.WriteLine($"\nOlá, meu nome é {nome} {sobrenome}\n");
        }
    }
}