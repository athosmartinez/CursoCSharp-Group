using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção14_5.Entities
{
    internal class Employee : IComparable
    {

        public string Name { get; set; }    
        public double Salary { get; set; }

        public Employee(string csvEmplyee) {
            string[] vect = csvEmplyee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1]);

        }

        public override string ToString()
        {
            return Name  + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing ERROR: Arggument is not an Employee");
            }
            Employee other = obj as Employee;
            return Salary.CompareTo(other.Name);
        }
    }
}
