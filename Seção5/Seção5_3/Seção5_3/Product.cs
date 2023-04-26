using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção5_3
{
    internal class Product
    {
        //atributo privado
        private string _nome;
        //propriedades autoimplementadas
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //construtores
        public Product() { }
        public Product(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //propriedades customizadas
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //outros metodos
        public double TotalValueStock()
        {
            return Preco * Quantidade;
        }

        public void AddProduct(int quantidade)
        {
            if (quantidade > 0)
            {
                Quantidade = Quantidade + quantidade;

            }
        }

        public void RemoveProduct(int quantidade)
        {
            if (quantidade > 0)
            {
                Quantidade = Quantidade - quantidade;

            }
        }

        public override string ToString()
        {
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + TotalValueStock().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
