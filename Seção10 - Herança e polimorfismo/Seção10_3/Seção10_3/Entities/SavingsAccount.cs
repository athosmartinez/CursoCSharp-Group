using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção10_3.Entities
{
    internal class SavingsAccount : Account
    {
        public double InteresRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interesRate) : base(number, holder, balance)
        {
            InteresRate = interesRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InteresRate;
        }

        public override void WithDraw(double amount)
        {
            Balance -= amount;
            //base.WithDraw(amount);
            //Balance -= 2.0;
        }
    }
}
