using System;
using System.Globalization;
using Seção5_2;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product p = new Product();
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.SetNome(Console.ReadLine());
            Console.Write("Preço: ");
            p.SetPreco(double.Parse(Console.ReadLine()));
            Console.Write("Quantidade: ");
            p.SetQuantidade(int.Parse(Console.ReadLine()));

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