using System.Security.Principal;
using OnlineBankingSystem;

namespace ATM
{
    public class Options
    {
        
        public virtual void DisPlayOptions()
        {
            

            Console.WriteLine("1-(200 EGP)              2-(500 EGP)" +
                                         "\n3-(700 EGP)              4-(1000 EGP)" +
                                         "\n5-(Another amount)         6-(Other services)\n");

            int ChooseNumber = int.Parse(Console.ReadLine());
            if (ChooseNumber == 1)
            {
                var num1 = balance - 200;
                Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx
            }
            else if (ChooseNumber == 2)
            {
                var num2 = balance - 500;
                Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx
            }
            else if (ChooseNumber == 3)
            {
                var num3 = balance - 700;
                Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx
            }
            else if (ChooseNumber == 4)
            {
                var num4 = balance - 1000;
                Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx
            }
            else if (ChooseNumber == 5)
            {
                Console.WriteLine($"\nYour Current Balance: {balance} EGP\n\nThe maximum withdrawal amount is 5000 EGP and the minimum amount is 50 EGP");
                double amount = double.Parse(Console.ReadLine());
                if (amount >=5000 && amount<50)
                {
                    Console.WriteLine("Please Enter Correct Amount");
                   
                }
                else
                {
                    var result = balance - amount;
                    Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx

                }
            }
            else if (ChooseNumber == 6)
            {

                Console.WriteLine("1-(Deposit)     2-(Balance Inquiry)");
                int x = int.Parse(Console.ReadLine());
                OtherService services = new OtherService();
                if (x == 1)
                {
                    Console.WriteLine("\nPlease Enter The Amount\n");
                    double i = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\nAmount Added " + i);
                    Console.WriteLine(services.Deposit(i));
                    Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx
                }
                else if (x == 2)
                {
                    services.BalanceInquiry();
                    Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx
                }
            }
        

            Console.WriteLine("\n\n هل ترغب في خدمات اخرى");  //xxxxxxxxxxxxxxxxxxxxxxxxxxxx
            Console.WriteLine("\n1-yes        2-no\n");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                DisPlayOptions();
            }
            else
            {
                Console.WriteLine("Thank You");
            }

        }
    }
}