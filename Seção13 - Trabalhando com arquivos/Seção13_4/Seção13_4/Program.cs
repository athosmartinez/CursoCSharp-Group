using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\athos.andrade\source\repos\CursoCSharp-Group\Seção13 - Trabalhando com arquivos\Archives\4\file1.txt";
            string targetpath = @"C:\Users\athos.andrade\source\repos\CursoCSharp-Group\Seção13 - Trabalhando com arquivos\Archives\4\file2.txt";
            string soucepath2 = @"C:\Users\athos.andrade\source\repos\CursoCSharp-Group\Seção13 - Trabalhando com arquivos\Archives\4\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());

                    }

                }
                using (StreamReader sr = File.OpenText(soucepath2))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Houve um erro: " + ex.Message);
            }
        }
    }
}