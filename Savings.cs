using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Savings : Account
    {
        public decimal IntrestRate { get; set; } = 0.01m;
        decimal CalculateIntrest (int months) { return Balance * (IntrestRate / 12) * months;}
        Account account = new Account();
        public decimal CalculatePayIntrest(int months)
        {
            

            var intrest = this.account.Balance * (IntrestRate / 12) * months;
            this.account.Deposit(intrest);
            return intrest;
        }

    }
}
