using System;
using System.Linq;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // AULA 02

            /*-----------------------------------------------------------------------*/

            // int[] arrayInteiros = new int[3];
            
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;

            // comentados os 2 abaixo ***
            // arrayInteiros[2] = int.Parse"30"; isso é possível
            //arrayInteiros[3] = 40; isso n é possível, pois passa do tamanho máximo do array
            // ***


            // System.Console.WriteLine("=========================\n");
            // System.Console.WriteLine("Utilizando for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("=========================\n");

            // System.Console.WriteLine("Utilizando foreach");

            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }

            // System.Console.WriteLine("=========================\n");

            /*-----------------------------------------------------------------------*/

            // int[,] matriz = new int[4, 2]
            // {
            //     { 8, 8 },
            //     { 10, 20 },
            //     { 50, 20 },
            //     { 21, 82 },
            // };

            // System.Console.WriteLine("=========================\n");

            // System.Console.WriteLine("Utilizando for na matriz");

            // for (int lin = 0; lin < matriz.GetLength(0); lin++)
            // {
            //     for (int col = 0; col < matriz.GetLength(1); col++)
            //     {
            //         System.Console.WriteLine(matriz[lin, col]);
            //     }
            // }

            // System.Console.WriteLine("=========================\n");

            // System.Console.WriteLine("Utilizando foreach na matriz");
            // foreach (int item in matriz)
            // {
            //     System.Console.WriteLine(item);
            // }

            // System.Console.WriteLine("=========================\n");



            /*-----------------------------------------------------------------------*/



            // AULA 03

            /*---------------------------------------------------------------------*/
            // bubble sort

            // visualgo.net/en/sorting
            
            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // int[] array2 = new int[5] {12, 33, 5, 1, 29};

            // OperacoesArray op = new OperacoesArray();

            // System.Console.WriteLine("\nArray original");
            // op.ImprimirArray(array);
            // System.Console.WriteLine("=======================\n");
            // op.OrdenarBubbleSort(ref array);
            // System.Console.WriteLine("Array modificado");
            // op.ImprimirArray(array);
            // System.Console.WriteLine("=======================\n");

            // System.Console.WriteLine("\nArray2 original");
            // op.ImprimirArray(array2);
            // System.Console.WriteLine("=======================\n");
            // op.Ordenar(ref array2);
            // System.Console.WriteLine("Array2 modificado");
            // op.ImprimirArray(array2);
            // System.Console.WriteLine("=======================\n");



            /*---------------------------------------------------------------------*/
            // copiando um array
            
            // OperacoesArray op = new OperacoesArray();

            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // int[] arrayCopia = new int[10];

            // System.Console.WriteLine("\nArrays originais (o 2º é o copiado)");
            // op.ImprimirArray(array); 
            // op.ImprimirArray(arrayCopia); 
            // System.Console.WriteLine("=======================\n");

            // System.Console.WriteLine("\nArrays pós Copia (o 2º é o copiado)");
            // op.Copiar(ref array, ref arrayCopia);
            // op.ImprimirArray(array); 
            // op.ImprimirArray(arrayCopia); 

            // System.Console.WriteLine("=======================\n");

            /*---------------------------------------------------------------------*/
            // verificando a existencia de um elemento

            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // OperacoesArray op = new OperacoesArray();

            // int valorProcurado = 55;

            // bool existe = op.Existe(array, valorProcurado);
            // if(existe)
            // {
            //     System.Console.WriteLine($"\nEncontrei o valor {valorProcurado}\n");
            // } 
            // else
            // {
            //     System.Console.WriteLine($"\nNÃO encontrei o valor {valorProcurado}\n");
            // }

            /*---------------------------------------------------------------------*/
            // VERIFICANDO TODOS OS ELEMENTOS DO ARRAY
            // só irá retornar vdd se TODOS forem maior que o numero

            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // OperacoesArray op = new OperacoesArray();

            // int valorProcurado = 5;

            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if(todosMaiorQue)
            // {
            //     System.Console.WriteLine($"\nTodos os valores são maiores que: {valorProcurado}\n");
            // } 
            // else
            // {
            //     System.Console.WriteLine($"\nNEM todos os valores são maiores que: {valorProcurado}\n");
            // }

            /*---------------------------------------------------------------------*/
            
            // ENCONTRANDO UM ELEMENTO NO ARRAY

            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // OperacoesArray op = new OperacoesArray();

            // int valorProcurado = 93;

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine($"\nEncontrei o valor: {valorProcurado}\n");
            // } 
            // else
            // {
            //     System.Console.WriteLine($"\nNÃo encontrei o valor: {valorProcurado}\n");
            // }

            /*---------------------------------------------------------------------*/

            // encontrando o indice de um valor Indexof

            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // OperacoesArray op = new OperacoesArray();

            // int valorProcurado = 6;

            // int indiceAchado = op.ObterIndice(array, valorProcurado);

            // if(indiceAchado > -1)
            // {
            //     System.Console.WriteLine($"\nEncontrei o valor: {valorProcurado}, na posição: {indiceAchado}\n");
            // } 
            // else
            // {
            //     System.Console.WriteLine($"\nNÃO encontrei o valor: {valorProcurado}\n");
            // }

            /*---------------------------------------------------------------------*/
            // REDIMENSIONANDO UM ARRAY

            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // OperacoesArray op = new OperacoesArray();


            // System.Console.WriteLine($"\nCapacidade original: {array.Length}\n");


            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"\nCapacidade modificada: {array.Length}\n");

            /*---------------------------------------------------------------------*/
            // CONVERTENDO ARRAYS

            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // OperacoesArray op = new OperacoesArray();

            // string[] arrayString = op.ConvertendoParaString(array);

            // foreach (var item in arrayString)
            // {
            //     System.Console.WriteLine(item);
            // }

            /*---------------------------------------------------------------------*/



            // AULA 04 ***              ***              ***

            /*---------------------------------------------------------------------*/

            // DECLARANDO E ACESSANDO UMA LISTA

            // List<string> estados = new List<string>();
            // estados.Add("SP");
            // estados.Add("MG");
            // estados.Add("BA");
            
            // System.Console.WriteLine($"\nQuantidade de elementos na lista: {estados.Count}");

            // System.Console.WriteLine("\nUtilizando foreach");
            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }
            // System.Console.WriteLine("\n=======================\n");
            // System.Console.WriteLine("Utilizando for");
            // for (int i = 0; i < estados.Count; i++)
            // {
            //     System.Console.WriteLine($"Indice {i} = {estados[i]}");
            // }

            // System.Console.WriteLine("\n=======================\n");


            /*---------------------------------------------------------------------*/

            // Removendo elementos da lista


            // OperacoesLista opLista = new OperacoesLista();

            // List<string> estados = new List<string>();
            // estados.Add("SP");
            // estados.Add("MG");
            // estados.Add("BA");
            

            // opLista.ImprimirLista(estados);

            // System.Console.WriteLine("Removendo o elemento...");
            // estados.Remove("MG");


            // opLista.ImprimirLista(estados);

            /*---------------------------------------------------------------------*/

            // Adicionando coleções na lista


            // OperacoesLista opLista = new OperacoesLista();

            // List<string> estados = new List<string> {"SP", "MG", "BA"};

            // string[] estadosArray = new string[2] {"SC", "MT"};

            // System.Console.WriteLine("\nLista original: ");
            // opLista.ImprimirLista(estados);

            // estados.AddRange(estadosArray);

            // System.Console.WriteLine("Lista modificada: ");
            // opLista.ImprimirLista(estados);

            /*---------------------------------------------------------------------*/

            // adicionando elemento por indice

            // OperacoesLista opLista = new OperacoesLista();

            // List<string> estados = new List<string> {"SP", "MG", "BA"};


            // System.Console.WriteLine("\nLista original: ");
            // opLista.ImprimirLista(estados);

            // estados.Insert(1, "RJ");

            // System.Console.WriteLine("Lista modificada: ");
            // opLista.ImprimirLista(estados);

            /*---------------------------------------------------------------------*/


            // AULA 05 ----------        ***             ***

            // FILAS NA PRATICA

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Eduardo");
            // fila.Enqueue("André");
            
            // System.Console.WriteLine($"\nPessoas na fila: {fila.Count}\n");
            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo: {fila.Peek()}");
            //     System.Console.WriteLine($"Vez de: {fila.Dequeue()}");
            // }
            // System.Console.WriteLine($"\nPessoas na fila: {fila.Count}\n");

            /*---------------------------------------------------------------------*/

            // PILAS NA PRATICA

            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Código Limpo");

            // System.Console.WriteLine($"\nLivro para leituras: {pilhaLivros.Count}\n");
            // while (pilhaLivros.Count > 0)
            // {   
            //     System.Console.WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"Livro lido: {pilhaLivros.Pop()}");
            // }

            // System.Console.WriteLine($"\nLivro para leituras: {pilhaLivros.Count}\n");


            /*---------------------------------------------------------------------*/

            // AULA 06 DICIONARIOS

            // dicionario na pratica

            // Dictionary<string, string> estado = new Dictionary<string, string>();

            // estado.Add("SP", "São Paulo");
            // estado.Add("MG", "Minas Gerais");
            // estado.Add("BA", "Bahia");
            
            // System.Console.WriteLine("\n========================\n");
            // foreach (KeyValuePair<string, string> item in estado)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }
            // System.Console.WriteLine("\n========================\n");

            /*---------------------------------------------------------------------*/

            // acessando um valor

            // Dictionary<string, string> estado = new Dictionary<string, string>();

            // estado.Add("SP", "São Paulo");
            // estado.Add("MG", "Minas Gerais");
            // estado.Add("BA", "Bahia");
            
            // string valorProcurado = "BA";

            // System.Console.WriteLine("\n========================\n");
            // System.Console.WriteLine(estado[valorProcurado]);
            // System.Console.WriteLine("\n========================\n");



            /*---------------------------------------------------------------------*/

            // Atualizando valor

            // Dictionary<string, string> estado = new Dictionary<string, string>();

            // estado.Add("SP", "São Paulo");
            // estado.Add("MG", "Minas Gerais");
            // estado.Add("BA", "Bahia");

            // string valorProcurado = "BA";


            // System.Console.WriteLine($"\nValor original: {estado[valorProcurado]}");
            // System.Console.WriteLine("\n========================\n");
            // estado[valorProcurado] = "BA - teste";
            // System.Console.WriteLine($"Valor modificado: {estado[valorProcurado]}\n");




            /*---------------------------------------------------------------------*/

            // Removendo um valor

            // Dictionary<string, string> estado = new Dictionary<string, string>();

            // estado.Add("SP", "São Paulo");
            // estado.Add("MG", "Minas Gerais");
            // estado.Add("BA", "Bahia");

            // string valorProcurado = "BA";

            // System.Console.WriteLine("\n========================\n");
            // foreach (KeyValuePair<string, string> item in estado)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }
            // System.Console.WriteLine("\n========================\n");


            // System.Console.WriteLine($"Removendo: {valorProcurado}");

            // estado.Remove(valorProcurado);

            // System.Console.WriteLine("\n========================\n");
            // foreach (KeyValuePair<string, string> item in estado)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }
            // System.Console.WriteLine("\n========================\n");

            /*---------------------------------------------------------------------*/

            // acessando valor de maneira segura

            // Dictionary<string, string> estado = new Dictionary<string, string>();

            // estado.Add("SP", "São Paulo");
            // estado.Add("MG", "Minas Gerais");
            // estado.Add("BA", "Bahia");

            // string valorProcurado = "SC";

            // System.Console.WriteLine("\n");
            // if(estado.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else 
            // {
            //     System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            // }
            // System.Console.WriteLine("\n");


            /*---------------------------------------------------------------------*/





            // AULA 07 -           ----------              ---------     


            // Obtendo e ordenando valores LINQ

            // int[] arrayNumeros = new int[5] {1, 4, 8, 15, 19};

            // var numerosParesQuery =
            //         from num in arrayNumeros
            //         where num % 2 == 0
            //         orderby num
            //         select num;

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();


            // System.Console.WriteLine("\nNumeros original: " + string.Join(", ", arrayNumeros));

            // System.Console.WriteLine("\nNumeros pares query: " + string.Join(", ", numerosParesQuery));

            // System.Console.WriteLine("\nNumeros pares metodo: " + string.Join(", ", numerosParesMetodo));


            /*---------------------------------------------------------------------*/

            // Valores minimo, maximo e medio com LINQ

            // int[] arrayNumeros = new int[7] {100, 1, 4, 0, 8, 15, 19};

            // var minimo = arrayNumeros.Min();
            // var maximo = arrayNumeros.Max();
            // var medio = arrayNumeros.Average();

            // System.Console.WriteLine($"\nMinimo: {minimo}");
            // System.Console.WriteLine($"\nMaximo: {maximo}");
            // System.Console.WriteLine($"\nMedio: {medio}\n");





            /*---------------------------------------------------------------------*/

            // SUM E DISTINTC

            int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"\nSoma: {soma}\n");
            System.Console.WriteLine($"\nArray original: {string.Join(", ", arrayNumeros)}");
            System.Console.WriteLine($"\nArray distinto: {string.Join(", ", arrayUnico)}\n");
            /*---------------------------------------------------------------------*/

        }
    }
}
