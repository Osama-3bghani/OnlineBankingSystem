using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class OtherService:ATMService
    {
        public void BalanceInquiry()
        {
            Console.WriteLine("Your Current Balance: " + balance);
        }

        public string Deposit(double money)
        {
            return $"Your Current Balance: {money + balance} EGP";
        }
    }
}
