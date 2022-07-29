using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);

        // dividir já tem o método implementado, então a class NÃO é obrigada a implementar, porem pode ser sobescrito
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}