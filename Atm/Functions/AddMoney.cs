using Atm.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.App
{
    internal class AddMoney //: IAddMoneyToCard //, IAddMoneyToIBAN
    {
        //static double a = new CardOwner().Balance; //a yı kullanmak için yapmıştım method a mainden göndrince gerek kalmadı
        public static double AddMoneyToCard(double a)
           {
           
                Console.Clear();
                Console.WriteLine("--------------------WELCOME----------------------");
                Console.WriteLine("You choose 2");
            
            while (true)
            {
                Console.WriteLine($"\nYou currently have: {a}$");
                Console.WriteLine("\n(Please place 500$ at each time.)");
               
                double money = Utility.Money("add? : ");
                if (money <= 500)
                {
                    a += money;
                    Console.WriteLine($"\nYou put {money}$.");
                    Console.WriteLine($"You currently have: {a}$\n");
                }
                else if(money > 500 )
                {
                    Console.WriteLine("\nPlease place 500$ at most.");
                    Thread.Sleep(1300);
                    //Console.Clear();
                    continue;
                }

                Console.WriteLine("To add 'N' to see your balance press 'B' to exit press 'Q' ");
                char c = Convert.ToChar(Console.ReadLine());
                if(c == Convert.ToChar(ConsoleKey.N))
                {
                    continue;
                }
                else if(c == Convert.ToChar(ConsoleKey.B))
                {
                    break;
                }
                else if ( c == Convert.ToChar(ConsoleKey.Q))
                {
                    Environment.Exit(0);
                }
                break;
            }
            return a;
        }
    }
}
