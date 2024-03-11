using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBankingSystem
{
    public class Transfer:Transaction
    {
       
        public void DoTransfer() 
        {
            Console.WriteLine("Enter Your AccountNo");
            int accountNo = int.Parse(Console.ReadLine());
            Account account = new Account();
            for (int i = 0; i < account.AccountNO.Length; i++) 
            {
                if (accountNo == account.AccountNO[i])
                {
                    Console.WriteLine("Enter Your Amount");
                    Amount = Convert.ToDouble(Console.ReadLine());
                    if (Amount <= account.Balance[i]) 
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Enter The Reciver Number");
                        int recieverNo = Convert.ToInt32(Console.ReadLine());
                        for (int x = 0; x < account.AccountNO.Length; x++)
                        {
                            if (recieverNo == account.AccountNO[x])
                            {
                                
                                account.Balance[x] = account.Balance[x] + Amount;
                                Console.WriteLine("Done");
                            }
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Your Amount Is Exceeding Your Balance"); 
                    }
                    
                }
            } 
        }
    }
}
