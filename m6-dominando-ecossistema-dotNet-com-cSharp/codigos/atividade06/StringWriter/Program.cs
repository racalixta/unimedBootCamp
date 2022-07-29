string textReaderText = "TextReader é a classe base abstrata " +
                        "de SteamReader e StringReader, que lê caracteres " +
                        "de streams e string, respectivamente.\n\n" +

                        "Crie uma instância de TextReader para abrir um arquivo de texto " + 
                        "para ler um intervalo especificado de caracteres " + 
                        "ou para criar um leitor dbaseado em um fluxo existente.\n\n" +

                        "Você também pode usar uma instância de TextReader para ler " +
                        "texto de um armazenamento de suporte personalizado usando as mesmas " +
                        "APIs que vocÊ usaria para uma string ou um fluxo.\n\n";


Console.WriteLine($"Texto original:\n{textReaderText}");

string linha, paragrafo = null;

var sr = new StringReader(textReaderText);

while(true)
{
    linha = sr.ReadLine();

    if(linha != null)
    {
        paragrafo += linha + " "; 
    }
    else
    {
        paragrafo += "\n";
        break;
    }
}

Console.WriteLine($"Texto modificado: \n{paragrafo}");

int caracterLido;
char caracterConvertido;

var sw = new StringWriter();

sr = new StringReader(paragrafo);

while(true)
{
    caracterLido = sr.Read();
    if(caracterLido == -1) break;

    caracterConvertido = Convert.ToChar(caracterLido);

    if(caracterConvertido == '.')
    {
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(caracterConvertido);
    }

}
Console.WriteLine($"Texto armazenado no StringWriter: {sw.ToString()}");
Console.WriteLine("Pressione enter para fechar...");
Console.ReadLine();



