using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirLista(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Indice {i} = {lista[i]}");
            }
            
            System.Console.WriteLine("\n=======================\n");
        }




    }
}