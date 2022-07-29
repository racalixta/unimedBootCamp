var path = @"C:\Users\usuário\Desktop\projeto\unimedBootCamp\m6-dominando-ecossistema-dotNet-com-cSharp\codigos\atividade06\Diretorio\globo";

LerDiretorios(path);

Console.WriteLine("Digite [enter] para finilizar");
Console.ReadLine();

static void LerDiretorios(string path)
{
    if(Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path,"*",SearchOption.AllDirectories);

        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[Nome]: {dirInfo.Name}");
            Console.WriteLine($"[Raiz]: {dirInfo.Root}");

            if(dirInfo.Parent != null)
                Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");

            Console.WriteLine("------------------------------\n");
        }
    } 
    else 
    {
        Console.WriteLine("Diretorio não existe");
    }

}
