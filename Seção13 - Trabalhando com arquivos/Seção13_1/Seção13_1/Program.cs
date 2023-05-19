using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\Users\athos.andrade\source\repos\CursoCSharp-Group\Seção13 - Trabalhando com arquivos\Archives\1\file1.txt";
            string targetPath = @"C:\Users\athos.andrade\source\repos\CursoCSharp-Group\Seção13 - Trabalhando com arquivos\Archives\1\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[]lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines) {
                    Console.WriteLine(line);
                }


            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }

        }
    }
}