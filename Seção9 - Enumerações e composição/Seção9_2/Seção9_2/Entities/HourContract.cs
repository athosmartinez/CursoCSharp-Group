using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Seção9_2.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() { }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return Hours * ValePerHour;
        }
    }
}
