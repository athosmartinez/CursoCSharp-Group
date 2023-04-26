using System;
using System.Globalization;
using Seção5_1;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string NomeAux = Console.ReadLine();
            Console.Write("Preço: ");
            double PrecoAux = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int QuantidadeAux = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Product p = new Product(NomeAux, PrecoAux, QuantidadeAux);
            Product p2 = new Product();

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