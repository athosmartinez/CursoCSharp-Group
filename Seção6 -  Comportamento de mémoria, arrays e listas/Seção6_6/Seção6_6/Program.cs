using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vector = new string[] { "Maria", "Alex", "Bob" };
            foreach (string s in vector)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------------------------");
            List<string> list = new List<string>();
            list.Add("Pedro");
            list.Add("Athos");
            list.Add("Amaral");
            list.Insert(2, "Marcos");
            list.Add("Mario");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("Last M: " + s2);
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + pos2);
            List<string> filterList = list.FindAll(x => x.Length == 5);
            foreach (string writeFilterList in filterList)
            {
                Console.WriteLine("Os que tem 5 caracteres: " + writeFilterList);
            }
            Console.WriteLine("-------------------------------------");
            filterList.Remove("Mario");
            foreach (string RemoveItem in filterList)
            {
                Console.WriteLine(RemoveItem);
            }



        }
    }
}