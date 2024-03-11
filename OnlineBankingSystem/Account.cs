using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBankingSystem
{
    public class Account
    {
        public string[] BankName { get; set; } = {"Qnb","Cib","Nbk","Hsbc" };
        public long[] AccountNO { get; set; } = {11,22,33,44};
        public double[] Balance { get; set; } = {22500.30,10000,20000,35000.70 };


        public void UpdateAccount()
        {
            Console.WriteLine("Enter Your Account Number");
            int accountno = int.Parse(Console.ReadLine());
            for (int i=0;i<AccountNO.Length;i++) 
            {
                if (accountno == AccountNO[i])
                {
                    Client client = new Client();
                    Console.WriteLine("Enter your Name");
                    client.Name[i] = Console.ReadLine();
                    Console.WriteLine("Enter Your Phone");
                    client.Phone[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Your Email");
                    client.Email[i] = Console.ReadLine();
                    Console.WriteLine
                        ($"Your Name Is {client.Name[i]} and Your Phone Is {client.Phone[i]} and Your Email Is {client.Email[i]} ");
                }

            }

        }

        public void CheckBalance()
        {
            Console.WriteLine("Enter Your Account Number");
            int accountno = int.Parse(Console.ReadLine());
            for (int i = 0; i < AccountNO.Length; i++)
            {
                if (accountno == AccountNO[i])
                {
                    Console.WriteLine(Balance[i]);
                }
            }
            
        }

        public void DoAccount() 
        {
            Console.WriteLine("For Update Account Press 1 For Check Balance Press 2");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 1)
            {
                UpdateAccount();
            }
            else if (num2 == 2)
            {
                CheckBalance();
            }
            else
            {
                Console.WriteLine("You Pressed A wrong number");
            }
        }
    }
}
