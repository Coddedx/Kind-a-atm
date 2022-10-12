using Atm.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.App
{
    internal class Withdrawal //: IWithdrawalFromCard
    {
        static double balance = new CardOwner().Balance;  //cardOwner classının Balance sini balance değerime eşitliyorum
        public static double WithdrawalFromCard(double balance)   //static olmayınca main den çağıramıyorum??
        {
            Console.Clear();
            Console.WriteLine("--------------------WELCOME----------------------");
            Console.WriteLine("\nYou choose 1");

            while (true)
            {
                Console.WriteLine($"You currently have: { balance }\n");
                Console.WriteLine("(You can only withdrawal 500$ at each time)");

                double money = Utility.Money("withdrawel? :  "); //ne kadar para çekmesi istediğini sorup moneyi buraya döndürüyorum
                if (balance > money && money<=500)
                {
                    balance -= money;
                    Console.WriteLine("\nI'm giving you the money.Hold on...");
                    Thread.Sleep(1500);
                    Console.WriteLine($"\nYou take {money}.$ \n");
                    Console.WriteLine($"You currently have: {balance}\n");
                }
                else if( balance < money)
                {
                    Console.WriteLine("\nYou don't have enough money to withdrawal.\n\n");
                    continue;
                }
                else if( money>500 )
                {
                    Console.WriteLine("\nYou can only withdrawal 500$ at each time.Please try again...");
                    Thread.Sleep(1300);
                    //Console.Clear();
                    continue;
                }

                Console.WriteLine("To withdrawal 'N' to see your balance press 'B' to exit press 'Q' ");
                char c = Convert.ToChar(Console.ReadLine());
                if (c == Convert.ToChar(ConsoleKey.N))
                {
                    continue;
                }
                else if (c == Convert.ToChar(ConsoleKey.B))
                {
                    break;
                }
                else if (c == Convert.ToChar(ConsoleKey.Q))
                {
                    Environment.Exit(0);
                }
                break;
            }
            return balance;
        }


        //try
        //{

        //}
        //catch (Exception)
        //{

        //    throw;
        //}

        //public void WithdrawalFromCard(int n)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
