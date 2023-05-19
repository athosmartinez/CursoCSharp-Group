using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\athos.andrade\source\repos\CursoCSharp-Group\Seção13 - Trabalhando com arquivos\Archives\2\file1.txt";

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu: " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();

            }
        }
    }
}