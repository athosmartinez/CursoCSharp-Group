﻿using Seção10_4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção10_4.Entities
{
    internal class BussinesAccount : Account
    {
        public double LoanLimit { get; set; }
        public BussinesAccount() { }

        public BussinesAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
        {
            LoanLimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
