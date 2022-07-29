
var path = @"C:\Users\usuário\Desktop\projeto\unimedBootCamp\m6-dominando-ecossistema-dotNet-com-cSharp\codigos\atividade06\Diretorio\globo";

using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;


Console.WriteLine($"\nMonitorando eventos na pasta {path}\n");
Console.WriteLine("\nPressione enter para finalizar...\n");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi deletado o arquivv {e.Name}");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
}

