using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OnlineBankingSystem
{
    public class Transaction
    {
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public Transaction()
        {
            Type = string.Empty;
            Date = DateTime.Now;
            Amount = 0;
        }
        public Transaction(string type, DateTime date,double amount)
        {
            Type=type;
            Date = date;
            Amount = amount;
        }
        public void DoTransaction() 
        {
            Console.WriteLine("Press 1 for Deposite and Press 2 for Transfer and Press 3 for Withdraw");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Deposit deposit = new Deposit();
                deposit.DoDeposit();
            }
            else if (num == 2)
            {
                Transfer transfer = new Transfer();
                transfer.DoTransfer();
            }
            else if (num==3) 
            { 
                Withdraw withdraw = new Withdraw();
                withdraw.DoWithdraw();
            }
            else { Console.WriteLine("Your Pressed A Wrong Number");}
        }
    }
}
