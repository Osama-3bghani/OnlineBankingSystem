using ATM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBankingSystem
{
    public class Bank:ATMService
    {
        public void ProvideLoan()
        {
          Account account = new Account();
            Console.WriteLine("Enter Your Account Number");
            int accountNo= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Amount");
            double amount = double.Parse(Console.ReadLine());
            for (int i =0; i<account.AccountNO.Length;i++) 
            {
                if (accountNo == account.AccountNO[i]) 
                {
                    if (account.Balance[i] >= amount)
                    {
                        Console.WriteLine("Done");
                    }
                    else 
                    {
                        Console.WriteLine("Your Loan Is Exceeding Your Balance");
                    }
                }
            }
        }
        public void Update_Details()
        {
            Account account = new Account();
            account.UpdateAccount();
        }
        public void GetLocation()
        {
            Console.WriteLine(Location); 
        }

        public void DoBank() 
        {
            Console.WriteLine("For Branch Location Press 1 For Update Details Press 2 For Loan Press 3");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                GetLocation();
            }
            else if (num1 == 2)
            {
                Update_Details();
            }
            else if (num1 == 3)
            {
                ProvideLoan();
            }
            else
            {
                Console.WriteLine("You Pressed A wrong number");
            }
        }
    }
}
