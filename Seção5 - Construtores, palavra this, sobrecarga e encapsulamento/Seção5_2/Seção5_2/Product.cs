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
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Product() { }
        public Product(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            if (quantidade > 0)
            {
                _quantidade = quantidade;
            }
        }


        public double GetPreco()
        {
            return _preco;
        }

        public void SetPreco(double preco)
        {
            if (preco > 0)
            {
                _preco = preco;
            }
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

        }


        public double TotalValueStock()
        {
            return _preco * _quantidade;
        }

        public void AddProduct(int quantidade)
        {
            if (quantidade > 0)
            {
                _quantidade = _quantidade + quantidade;

            }
        }

        public void RemoveProduct(int quantidade)
        {
            if (quantidade > 0)
            {
                _quantidade = _quantidade - quantidade;

            }
        }

        public override string ToString()
        {
            return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: $" + TotalValueStock().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
