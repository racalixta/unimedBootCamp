using System;
using ExemploPOO.Models;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {

            //====================================================

            // Listar diretorios

            FileHelper helper = new FileHelper();

            var path = @"C:\Users\usuário\Desktop\projeto\unimedBootCamp\m6-dominando-ecossistema-dotNet-com-cSharp\codigos\atividade07\TrabalhandoComArquivos";

            var pathCombine = Path.Combine(path, "Pasta teste 3", "SubPasta Teste 3");

            var pathCombine2 = Path.Combine(path, "Pasta teste 3");

            var pathCombine3 = Path.Combine(path, "Pasta Teste 2", "arquivo-txt-stream.txt");

            var pathCombine4 = Path.Combine(path, "Pasta Teste 1", "arquivo-txt.txt");

            var pathArquivo = Path.Combine(path, "arquivo-text.txt");
            var pathArquivoStream = Path.Combine(path, "arquivo-text-stream.txt");

            var listaString = new List<string>{"linha 1", "linha 2", "Linha 3"};

            var listaString2 = new List<string>{"linha 4", "linha 5", "Linha 6"};

            // helper.ListarDiretorios(path);

            // helper.ListarArquivosDiretorios(path);

            // helper.CriarDiretorio(pathCombine);

            // helper.ApagarDiretorio(pathCombine2, true);

            // helper.CriarArquivoTexto(pathArquivo, "Olá mundo!");

            // helper.CriarArquivoTextoStream(pathArquivoStream, listaString);

            // helper.AdicionarTextoStream(pathArquivoStream, listaString2);

            // helper.AdicionarTexto(pathArquivo, "Parte 2 é mais");

            // helper.LerArquivoStream(pathArquivoStream);

            // helper.LerArquivo(pathArquivo);
            
            // helper.MoverArquivo(pathArquivoStream, pathCombine3);

            // helper.CopiarArquivo(pathArquivo, pathCombine4, true);

            helper.DeletarArquivo(pathCombine4);


            //====================================================

            // Interface

            // ICalculadora calc = new Calculadora();
            // Console.WriteLine($"\nSomar 6 + 2: {calc.Somar(6, 2)}\n");
            // Console.WriteLine($"\nSubtrair 6 - 2: {calc.Subtrair(6, 2)}\n");
            // Console.WriteLine($"\nMultiplicar 6 * 2: {calc.Multiplicar(6, 2)}\n");
            // Console.WriteLine($"\nDividir 6 / 2: {calc.Dividir(6, 2)}\n");

            //====================================================
            
            // Classe object

            // Computador comp = new Computador();
            // Console.WriteLine(comp.ToString());
            // herda de maneira implicita da classe System.object


            //====================================================

            // Classe Selada - não pode ter class filhas

            // Exemplo feito nas classes Diretor e Professor

            //====================================================

            // Class abstrata

            // Corrente c = new Corrente();
            // c.Creditar(1000);
            // c.ExibirSaldo();


            //====================================================

            // Polimorfismo tempo de compilação

            // Calculadora calc = new Calculadora();

            // Console.WriteLine($"\nResultado da primeira soma: {calc.Somar(5, 3)}\n");

            // Console.WriteLine($"\nResultado da segunda soma: {calc.Somar(5, 3, 13)}\n");


            //====================================================

            // Polimorfismo - em tempo de execução
            // o método Apresentar() foi sobreescrito(override) em ambas as class

            // Aluno a1 = new Aluno();
            // a1.Nome = "Bob";
            // a1.Idade = 16;
            // a1.Nota = 9;
            // a1.Apresentar();

            // Professor p1 = new Professor();
            // p1.Nome = "Rodolfo";
            // p1.Idade = 36;
            // p1.Salario = 2500;  
            // p1.Apresentar();



            //====================================================

            // AULA 03

            // Aluno a1 = new Aluno();
            // a1.Nome = "Alan";
            // a1.Idade = 16;
            // a1.Nota = 7;
            // a1.Apresentar();

            // Professor p1 = new Professor();
            // p1.Nome = "Bob";
            // p1.Idade = 36;
            // p1.Salario = 2500;  
            // p1.Apresentar();

            //====================================================
            
            // AULA 02

            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(7, 4);
            // Console.WriteLine($"\nA area do retangulo é: {r.ObterArea()}\n");

            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(7, 0);
            // Console.WriteLine($"\nA area do retangulo é: {r2.ObterArea()}\n");


            //====================================================

            // AULA 01
            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Apresentar();
        }        
    }    
}
