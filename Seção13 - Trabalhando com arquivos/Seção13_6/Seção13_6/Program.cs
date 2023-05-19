using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\athos.andrade\source\repos\CursoCSharp-Group\Seção13 - Trabalhando com arquivos\Archives\6\file1.txt";

            Console.WriteLine("DirectorySeparetorChar : " + Path.DirectorySeparatorChar);
            Console.WriteLine("Path Separator: " + Path.PathSeparator);
            Console.WriteLine("DirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension:" + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

        }
    }
}