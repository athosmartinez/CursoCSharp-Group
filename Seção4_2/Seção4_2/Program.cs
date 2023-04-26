using System;
using System.Globalization;
using Seção4_2;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int NewQntAdd = int.Parse(Console.ReadLine());
            p.AddProduct(NewQntAdd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos que serão removidos: ");
            int NewQntRemove = int.Parse(Console.ReadLine());
            p.RemoveProduct(NewQntRemove);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}