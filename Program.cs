using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var sav2 = new Savings2();
            sav2.Description = "SaveDatMoney";
            sav2.IntrestRate = 0.12m;
            sav2.Print();
            sav2.Deposit(5000);
            sav2.Withdraw(2000);
            sav2.CalculatePayIntrest(1);
            sav2.Print();

            var acct1 = new Account()
            { Id = 1, Description = "Test Checking"};
            acct1.Print();
            acct1.Deposit(9500);
            acct1.Print();
            //acct1.Withdraw(600);
          // acct1.Print();
          //var acct2 = new Account()
          //{ Id = 2, Description = "Test Savings" };
           // acct1.Transfer(1500 , acct2);
            acct1.Print();
            var sav1 = new Savings()
            { Id = 10, Description = "MyFristSavings" };
            sav1.IntrestRate = 0.12m;
            sav1.Deposit(5000);
            sav1.Withdraw(3000);
            sav1.CalculatePayIntrest(1);
            sav1.Print();
        }
    }
}                                 
