using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBankingSystem
{
    public class Withdraw:Transaction
    {
        public void DoWithdraw() 
        {
            Console.WriteLine("Enter Your AccountNo");
            int accountNo = int.Parse(Console.ReadLine());
            Account account = new Account();
            for (int i=0; i<account.AccountNO.Length;i++) 
            {
                if (accountNo == account.AccountNO[i]) 
                {
                    Console.WriteLine("Enter Your Amount");
                    Amount = Convert.ToDouble(Console.ReadLine());
                    if (Amount <= account.Balance[i])
                    {
                        account.Balance[i] = account.Balance[i] - Amount;
                    }
                    else { Console.WriteLine("Youre Amount Of Money Is Exceeding The limit Of Balance"); }

                    Console.WriteLine($"Your Amount Now Is {account.Balance[i]}");
                }
            }
           
        }
    }
}
