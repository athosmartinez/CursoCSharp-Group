using Seção14_3.Model.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção14_3.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }
        
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle Color = " + Color + ", Radius = " + Radius.ToString("F2", CultureInfo.InvariantCulture) + ", Area = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
