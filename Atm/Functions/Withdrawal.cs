using Atm.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.App
{
    public class Withdrawal //: IWithdrawalFromCard
    {
        public static double WithdrawalFromCard(double balance)   //static olmayınca main den çağıramıyorum??
        {
            int _bo=0;
            string c;
            Console.Clear();
            Console.WriteLine("--------------------WELCOME----------------------");
            Console.WriteLine("\nYou choose 1");
            try
            {
                while (true)
                {
                    Console.WriteLine($"\nYou currently have: {balance}\n");
                    Console.WriteLine("(You can only withdrawal 500$ at each time)");

                    double money = Utility.Money("withdrawel? :  "); //ne kadar para çekmesi istediğini sorup moneyi buraya döndürüyorum
                    if (balance > money && money <= 500)
                    {
                        balance -= money;
                        Console.WriteLine("\nI'm giving you the money.Hold on...");
                        Thread.Sleep(1500);
                        Console.WriteLine($"\nYou take {money}.$ \n");
                        Console.WriteLine($"You currently have: {balance}\n");
                    }
                    else if (balance < money)
                    {
                        Console.WriteLine("\nYou don't have enough money to withdrawal.\n\n");
                        continue;
                    }
                    else if (money > 500)
                    {
                        Console.WriteLine("\nYou can only withdrawal 500$ at each time.Please try again...");
                        Thread.Sleep(1300);
                        //Console.Clear();
                        continue;
                    }


                    while (true)
                    {
                        Console.WriteLine("To continue withdrawal 'N' , to see your balance press 'B' , to exit press 'Q' ");
                        c = Convert.ToString(Console.ReadLine());  //char yapınca birkaç karakter girince try-catch e düşemeden patlıyodu
                        if (c == Convert.ToString(ConsoleKey.N))
                        {
                            _bo = 1;
                            Console.Clear();
                            break;
                        }
                        else if (c == Convert.ToString(ConsoleKey.B))
                        {
                            break; //while döngüsünü kırıyor a choice deki switch-case nin add ile olana gönderiyor orda da zaten gösteriyor balanceyi 
                        }
                        else if (c == Convert.ToString(ConsoleKey.Q))
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nİnvalid expression. Try again.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(1500);
                            Console.Clear();
                            continue;
                        }

                    }
                    if (_bo == 1) { continue; }
                    else { break; }
                }
                return balance;
            }
            catch (Exception)
            {
                Console.WriteLine(" Something wrong.");
                return -1;
            }
        }
    }
}
