using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Savings2
    { private Account account { get; set; }
        public int Id => account.Id;
        public decimal Balance => account.Balance;
        public string Description 
        {
            get { return account.Description; } set { account.Description = value; } 
        }
        public decimal IntrestRate { get; set; } = 0.01m;
        public decimal CalculatePayIntrest (int months)
        { var intrest = this.account.Balance * (IntrestRate / 12) * months;
            this.account.Deposit(intrest);
            return intrest; }
        public bool Deposit(decimal amount) { return this.account.Deposit(amount); }
        public bool Withdraw(decimal amount) { return this.account.Withdraw(amount); }
        public bool Transfer(decimal amount, Account ToAccount) { return this.account.Transfer(amount, ToAccount); }
        public void Print() {this.account.Print(); }
        public Savings2()
        { this.account = new Account();
            this.account.Id = 1;
            this.account.Description = "New Savings2";
            }
    }
    
}
