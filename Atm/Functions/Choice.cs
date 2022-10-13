using Atm.App;
using Atm.Functions;
using Atm.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atm
{
    public class Choice
    {
        // public int ToContinueVariables { get; set; }
        static int deger=0;    
        public static int ToContinueVariables(int a)
        {
            deger = a;
            return a;
        }
        public static void ByChoice(int choice, double savings) //mainden kartı sokulan kişinin per.Balance sini alıyoruz yine console den işlem seçimini alıyoruz
        {
            while (true)
            {
                CardOwner per = new CardOwner();  //per e ulaşabilmek için 
                string c ;
                switch (choice)
                {
                    case 1:
                        double balance = Withdrawal.WithdrawalFromCard(savings);
                        Console.Clear();
                        Console.WriteLine("\n\n\n---------------------------------");
                        Console.WriteLine($"Current balance is {balance}$.  |");
                        Console.WriteLine("---------------------------------");
                        Thread.Sleep(1300);
                        break;
                    case 2:
                        double a = AddMoney.AddMoneyToCard(savings);
                        Console.Clear();
                        Console.WriteLine("\n\n\n---------------------------------");
                        Console.WriteLine($"Current balance is {a}$.    |");
                        Console.WriteLine("---------------------------------");
                        Thread.Sleep(1300);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("You choose 3");
                        Console.WriteLine("\n\n\n---------------------------------");
                        Console.WriteLine($"Current balance is {savings}$.  |");
                        Console.WriteLine("---------------------------------");
                        Thread.Sleep(1300);
                        break;
                    case 4:
                        LogOut.LogOutFromApp();
                        break;
                }
                while (true)
                {
                    int _cont = deger;  //HER TÜRLÜ 2 YE EŞİTLENDİĞİ İÇİN 
                    if (_cont == 2)
                    {
                        Console.WriteLine("To see Menu prees 'N' \nto exit press 'Q'");
                        c = Convert.ToString(Console.ReadLine());  //char yapınca birkaç karakter girince try-catch e düşemeden patlıyodu
                        if (c == Convert.ToString(ConsoleKey.N))
                        {
                            choice = AppScreen.Menu();
                            Choice.ByChoice(choice, savings);
                        }
                        else if (c == Convert.ToString(ConsoleKey.Q))
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Only prees 'N' or 'Q'");
                            continue;
                        }
                    }
                }
            }
        }
    }
}
