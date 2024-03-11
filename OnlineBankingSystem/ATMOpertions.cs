using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBankingSystem
{
    public class ATMOpertions
    {
        public void Operations(int i) 
        {
                Account account = new Account();
                Client client = new Client();

                int ChooseNumber = int.Parse(Console.ReadLine());
                if (ChooseNumber == 1)
                {
                    account.Balance[i] = account.Balance[i] - 200;
                Console.WriteLine($"Your Balance Is {account.Balance[i]}");
                Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx
                }
                else if (ChooseNumber == 2)
                {
                    account.Balance[i] = account.Balance[i] - 500;
                Console.WriteLine($"Your Balance Is {account.Balance[i]}");
                Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx
                }
                else if (ChooseNumber == 3)
                {
                    account.Balance[i] = account.Balance[i] - 700;
                Console.WriteLine($"Your Balance Is {account.Balance[i]}");
                Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx
                }
                else if (ChooseNumber == 4)
                {
                    account.Balance[i] = account.Balance[i] - 1000;
                Console.WriteLine($"Your Balance Is {account.Balance[i]}");
                Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx
                }
                else if (ChooseNumber == 5)
                {
                    Console.WriteLine($"\nYour Current Balance: {account.Balance[i]} EGP\n\nThe maximum withdrawal amount is 5000 EGP and the minimum amount is 50 EGP");
                    double amount = double.Parse(Console.ReadLine());
                    if (amount >= 5000 && amount < 50 && amount > account.Balance[i])
                    {
                        Console.WriteLine("Please Enter Correct Amount");

                    }
                    else
                    {
                        account.Balance[i] = account.Balance[i] - amount;
                    Console.WriteLine($"Your Balance Is {account.Balance[i]}");
                    Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx

                    }
                }
                else if (ChooseNumber == 6)
                {

                    Console.WriteLine("1-(Deposit)     2-(Balance Inquiry)");
                    int x = int.Parse(Console.ReadLine());
                    if (x == 1)
                    {
                        Console.WriteLine("\nPlease Enter The Amount\n");
                        double amount = double.Parse(Console.ReadLine());
                        Console.WriteLine($"\nAmount Added " + amount);
                        account.Balance[i] = account.Balance[i] + amount;
                        Console.WriteLine($"Your Balance Is {account.Balance[i]}");
                        Console.WriteLine("\nOperation Successfully , تمت العملية بنجاح"); //xxxxxxxxxxxx
                    }
                    else if (x == 2)
                    {
                        Console.WriteLine($"Youre Name Is {client.Name[i]} ");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine($"Youre Account Number Is {account.AccountNO[i]} ");
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine($"Youre Balance Is {account.Balance[i]} ");
                    }
                }

                Console.WriteLine("\n\n هل ترغب في خدمات اخرى");  //xxxxxxxxxxxxxxxxxxxxxxxxxxxx
                Console.WriteLine("\n1-yes        2-no\n");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                          Console.WriteLine("1-(200 EGP)              2-(500 EGP)" +
                                       "\n3-(700 EGP)              4-(1000 EGP)" +
                                      "\n5-(Another amount)         6-(Other services)\n");
                                Operations(i);     
                }
                else
                {

                    Console.WriteLine("Thank You");
                    
                }
        }
    }
}
