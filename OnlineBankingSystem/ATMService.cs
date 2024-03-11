using OnlineBankingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATMService
    {
        public string Location { get; set; } = "5 Mossadak Street, Dokki";
        public string BankName = "Ahly Bank";
        public string[] Pin = { "1234", "4321", "1357", "3333"};

        public void validationPin()
        { 
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Please Enter Your PIN , ادخل رقم السري\n");
            string pin = Console.ReadLine();
            if (pin.Length == 4)
            {
                for (int i = 0; i<Pin.Length; i++)
                {
                    if (Pin[i] == pin)
                    {
                        SelectLanguage();
                        ATMOpertions aTMOpertions = new ATMOpertions();
                        aTMOpertions.Operations(i);
                    }

                }
                  
            }
        }

        public void SelectLanguage()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("\nWelcom   مرحبا \n\n1-عربي \n\n2-English\n");
            int press= int.Parse(Console.ReadLine());
            if (press == 1)
            {
                
                Console.WriteLine("\n1-(200 EGP)              2-(500 EGP)" +
                             "\n3-(700 EGP)              4-(1000 EGP)" +
                             "\n5-(مبلغ اخر)-6          (خدمات اخرى)\n");
                
            }
            else if (press == 2)
            {
                
                Console.WriteLine("1-(200 EGP)              2-(500 EGP)" +
                             "\n3-(700 EGP)              4-(1000 EGP)" +
                             "\n5-(Another amount)         6-(Other services)\n");
                
            }
        }
    }
}
