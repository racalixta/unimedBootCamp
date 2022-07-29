using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    public delegate void Operacao(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            //===============================================

            // eventos na prática

            Matematica m = new Matematica(10, 20);
            m.Somar();


            //===============================================

            // delegate
            // Multi cast delegate 

            //Operacao op = Calculadora.Somar;      OUTRA FORMA DE FAZER
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;

            //op(10,3); ou 
            // op.Invoke(10, 3);  // faz as duas Operacoes, com uma unica chamada

            //===============================================

            // GET e SET na prática  

            // Data mes = new Data();
            // mes.SetMes(7);
            // mes.ApresentarMes();

            // Propriedades
            
            // mes.Mes = 12;
            // mes.ApresentarMes();


            //===============================================

            // Construtor da herança

            // Aluno p1 = new Aluno("Leo", "Buta", "Biologia");
            // p1.Apresentar();


            //===============================================

            // COnstrutor privado - evita instancia da classe

            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "\nTeste instância\n";

            // Log log2 = Log.GetInstance();

            // System.Console.WriteLine(log2.PropriedadeLog);

            //===============================================

            // AULA 01 - CONSTRUTOR NA PRática

            // Pessoa p1 = new Pessoa("Leo", "Buta");
            // p1.Apresentar();
        }
    }    
}
