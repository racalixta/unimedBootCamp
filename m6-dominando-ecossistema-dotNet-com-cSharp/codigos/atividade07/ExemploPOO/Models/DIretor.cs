using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class DIretor : Professor
    {
        
        public override void Apresentar()
        {
            Console.WriteLine($"\nOlá, sou diretor {Nome}");
        }
    }   
}