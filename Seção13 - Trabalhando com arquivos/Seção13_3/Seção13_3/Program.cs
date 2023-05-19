using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\athos.andrade\source\repos\CursoCSharp-Group\Seção13 - Trabalhando com arquivos\Archives\3\file1.txt";

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }


            }
            catch (IOException ex)
            {
                Console.WriteLine("Houve um erro: " + ex.Message);
            }

        }
    }
}