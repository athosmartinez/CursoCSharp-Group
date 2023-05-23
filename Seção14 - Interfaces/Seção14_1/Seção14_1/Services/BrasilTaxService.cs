using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção14_1.Services
{
    internal class BrasilTaxService
    {
        public double Tax(double amonunt)
        {
            if (amonunt <= 100)
            {
                return amonunt * 0.2;
            }
            else
            {
                return amonunt * 0.15;
            }
        }
    }
}
