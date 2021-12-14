using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class InsufficentFundsException
    {
        public decimal CurrentBalance {get; set;}
        public decimal AmmountToWithdraw { get; set; }
        public InsufficentFundsException(decimal CurrentBalance, decimal AmountToWithdraw) : base() 
        { this.CurrentBalance = CurrentBalance;
            this.AmmountToWithdraw = AmmountToWithdraw; }
        public InsufficentFundsException() : base() { }

    }
}
