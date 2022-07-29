using System.Text;

var sb = new StringBuilder();

sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("e a segunda linha ");
sb.AppendLine("e o fim!");


using var sr = new StringReader(sb.ToString());

var buffer = new char[10]; // será lido 10 caracteres (bytes) por vez

//var tamanho = 0;

// ISSO SERVE PARA APLICAÇÕES MAIORES
// do
// {
//     buffer = new char[10]; 
//     tamanho = sr.Read(buffer);
//     Console.Write(string.Join("",buffer));
// }while(tamanho >= buffer.Length);

// ESSE SERVE PARA APLICAÇÕES PEQUENAS
do
{
    Console.WriteLine(sr.ReadLine());
}while(sr.Peek() >= 0);

Console.WriteLine("\nDigite enter para finalizar\n");
Console.ReadLine();


