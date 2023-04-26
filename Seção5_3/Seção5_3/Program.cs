using System;
using System.Globalization;
using System.Security.Principal;
using Seção5_3;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product produto = new Product("TV", 500, 10);
            produto.SetNome("TV 4K");

            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto.GetPreco());

        }
    }
}