using static System.Console;

//CriarDiretoriosGlobo();
//CriarArquivo();

// var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
// var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Brasil", "brasil.txt");

//MoverArquivo(origem, destino);

// var origem2 = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Brasil", "brasil.txt");
// var destino2 = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Argentina", "brasil.txt");

//CopiarArquivo(origem2, destino2);

var path = @"C:\Users\usuário\Desktop\projeto\unimedBootCamp\m6-dominando-ecossistema-dotNet-com-cSharp\codigos\atividade06\Diretorio\globo";
LerArquivos(path);

static void LerArquivos(string path)
{
    var arquivos = Directory.GetFiles(path,"*",SearchOption.AllDirectories);

    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);
        Console.WriteLine($"[Nome]: {fileInfo.Name}");
        Console.WriteLine($"[Tamanho]: {fileInfo.Length}");
        Console.WriteLine($"[Último Acesso]: {fileInfo.LastAccessTime}");
        Console.WriteLine($"[Pasta]: {fileInfo.DirectoryName}");
        Console.WriteLine("----------------------------------------\n");

    }
}

/*

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        WriteLine("Arquivo de origem não existe");
        return;
    } 
    if(File.Exists(pathDestino))
    {
        WriteLine("Arquivo já existe na pasta destino");
        return;
    } 
    File.Copy(pathOrigem, pathDestino);
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        WriteLine("Arquivo de origem não existe");
        return;
    } 
    if(File.Exists(pathDestino))
    {
        WriteLine("Arquivo já existe na pasta destino");
        return;
    } 

    
    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");

    if(!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213M");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados atualizados em: 20/04/2022");
    }
}

static void CriarDiretoriosGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");

    if(!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);
        var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Mexico");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("CostaRica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguai");

    }

}

*/




