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
        public static double AddMoneyToCard(double a)
        {
            string c;
            int _bo=0;
            Console.Clear();
            Console.WriteLine("--------------------WELCOME----------------------");
            Console.WriteLine("You choose 2");
            try
            {
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
                    else if (money > 500)
                    {
                        Console.WriteLine("\nPlease place 500$ at most.");
                        Thread.Sleep(1300);
                        //Console.Clear();
                        continue;
                    }


                    //bu kısmı console to continue için yanlış bir şeylere basmasın diye yaptım
                    while (true)
                    {
                        Console.WriteLine("To continue adding press 'N' , \nTo see your balance 'B' \nTo exit press 'Q' ");
                        c = Convert.ToString(Console.ReadLine());  //char yapınca birkaç karakter girince try-catch e düşemeden patlıyodu
                        if (c == Convert.ToString(ConsoleKey.N))
                        {
                            _bo =1;
                            Console.Clear();
                            break;  //while döngüsünü kırıcak if _bo döngüsüne giricek _bo=1 old için continue olucak o da en baştaki while a göndercek ve tekrar tekrar para ekleyebilcem
                        }
                        else if (c == Convert.ToString(ConsoleKey.B))
                        {
                            _bo = 2;
                            Choice.ToContinueVariables(_bo);
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
                    if(_bo == 1) { continue; }
                    else { break; }
                }
                return a;
            }
            catch (Exception)
            {
                Console.WriteLine(" Something wrong.");
                return -1;
            }
        }
    }
}
