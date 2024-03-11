using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBankingSystem
{
    public class Deposit:Transaction
    {
        public void DoDeposit() 
        {
            Console.WriteLine("Enter Youre AccountNo");
            int accountNo = Convert.ToInt32(Console.ReadLine());
            Account account = new Account();
            for (int i=0;i<account.AccountNO.Length;i++) 
            {
                if (accountNo == account.AccountNO[i])
                {
                    Console.WriteLine("Enter Your Amount");
                    Amount = Convert.ToDouble(Console.ReadLine());
                    account.Balance[i] = account.Balance[i] + Amount;

                    Console.WriteLine($"Your Amount Now Is {account.Balance[i]}");
                }
               
            }
        }
    }
}
