using static System.Console;

WriteLine("Digite o nome do arquivo: ");
var nome = ReadLine();


nome = LimparNome(nome);


var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");



CriarArquivo(path);

WriteLine("Digite enter para finalizar...");
ReadLine();


static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Está é a linha 1 do arquivo");
        sw.WriteLine("Está é a linha 2 do arquivo");
        sw.WriteLine("Está é a linha 3 do arquivo");
    }
    catch
    {
        
        WriteLine("O nome do arquivo está inválido");
    }


}






// File.Create(path);

// omitindo o sw.Flush(), o using permite omitir o sw.Flush() no final do código, nesse caso pdoeria remover apenas
// using var sw = File.CreateText(path);
// var sw = File.CreateText(path);

// sw.WriteLine("Está é a linha 1 do arquivo");
// sw.WriteLine("Está é a linha 2 do arquivo");
// sw.WriteLine("Está é a linha 3 do arquivo");

// sw.Flush();
// // o sw.Flush() é responsável por escrever de fato no arquivo, o sw.WriteLine() só deixa na memória