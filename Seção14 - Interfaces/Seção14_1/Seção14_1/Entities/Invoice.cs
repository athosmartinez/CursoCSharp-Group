using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção14_1.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basePayment, double tax)
        {
            BasicPayment = basePayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get
            {
                return BasicPayment + Tax;
            }
        }

        public override string ToString()
        {
            return "Basic Payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture) + "\nTotal Payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
