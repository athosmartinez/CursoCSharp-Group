using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção5_2
{
    internal class Product
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public Product() { }
        public Product(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public double TotalValueStock()
        {
            return Preco * Quantidade;
        }

        public void AddProduct(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoveProduct(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + TotalValueStock().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
