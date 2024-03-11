using ATM;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace OnlineBankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If You Want To Use ATM System Press 1 Or If You Want To Use Our Online Banking System Press 2 ");
            int press= int.Parse(Console.ReadLine());
            if (press == 1)
            {
                ATMService aTMService = new ATMService();
                aTMService.validationPin();
            }
            else if (press == 2)
            {
                bool choose = true;
                while (choose)
                {
                    Console.WriteLine("For Bank Transaction Press 1 For Account Transaction Press 2 For Money Transaction Press 3");
                    int num = int.Parse(Console.ReadLine());
                    if (num == 1)
                    {
                        Bank bank = new Bank();
                        bank.DoBank();

                        Console.WriteLine("if You Want To Continue Press y If Not Press n");
                        char input = char.Parse(Console.ReadLine());
                        if (input == 'y')
                        {
                            choose = true;
                        }
                        else if (input == 'n')
                        {
                            choose = false;
                        }
                        else
                        {
                            Console.WriteLine("You Pressed A Wrong Character");
                            choose = false;
                        }
                    }

                    if (num == 2)
                    {
                        Account account = new Account();
                        account.DoAccount();

                        Console.WriteLine("if You Want To Continue Press y If Not Press n");
                        char input = char.Parse(Console.ReadLine());
                        if (input == 'y')
                        {
                            choose = true;
                        }
                        else if (input == 'n')
                        {
                            choose = false;
                        }
                        else
                        {
                            Console.WriteLine("You Pressed A Wrong Character");
                            choose = false;
                        }
                    }

                    if (num == 3)
                    {
                        Transaction transaction = new Transaction();
                        transaction.DoTransaction();

                        Console.WriteLine("if You Want To Continue Press y If Not Press n");
                        char input = char.Parse(Console.ReadLine());
                        if (input == 'y')
                        {
                            choose = true;
                        }
                        else if (input == 'n')
                        {
                            choose = false;
                        }
                        else
                        {
                            Console.WriteLine("You Pressed A Wrong Character");
                            choose = false;
                        }
                    }
                }
            }
            else 
            {
                Console.WriteLine("You Pressed A Wrong Number");
            }
        }
    }
}