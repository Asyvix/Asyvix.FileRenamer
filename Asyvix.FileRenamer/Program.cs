// See https://aka.ms/new-console-template for more information
using System.IO;

var dirs = Directory.GetDirectories("ㅋㅋ");

foreach (var dir in dirs)
{
    var indirs = Directory.GetDirectories(dir);
    foreach(var indir in indirs)
    {
        var files = Directory.GetFiles(indir);
        foreach (var file in files)
        {
            var dirname = Path.GetDirectoryName(file);
            string lastFolderName = Path.GetFileName(Path.GetDirectoryName(file));
            string fileName = Path.GetFileName(file);
            string newFileName = lastFolderName + " - " + fileName;
            File.Move(file, dirname + "/" + newFileName);
            Console.WriteLine(dirname + "/" + newFileName);

        }
    }

    //Console.WriteLine(dir);
}
Console.WriteLine("Hello, World!");
