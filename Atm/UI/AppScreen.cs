using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.UI
{
    public static class AppScreen  //örnekleyememek için static dedik. Tüm sınıflardan ulaşabilmek için public dedik
    {
        //değer döndürmeyeceği için void
        internal static void Welcome()
        {
            Console.Clear();
            Console.Title = "My ATM App";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------Welcome to my ATM app!--------------------------");
            Console.WriteLine("\nPlease ınsert your card...\n");
        }
       
        internal static int Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("         MENU ");
                Console.WriteLine("----------------------");
                Console.WriteLine("|  1- Withdrawal     |");
                Console.WriteLine("|  2- Put money      |");
                Console.WriteLine("|  3- See balance    |");
                Console.WriteLine("|  4- Log out        |");
                Console.WriteLine("----------------------");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();  //string tanımladık ki ayrıyetten int 1,2,3,4 ü çevirmeyelim
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")  //kullanıcı int de girse string de girse  sadece 1,2,3,4 ise seçimimi gönderiyorum
                {
                    int k = int.Parse(choice);
                    return k;
                }
                else
                {
                    Console.WriteLine("\nHatalı giriş. Tekrar yönlendiriyorum... ");
                    Thread.Sleep(800);
                    continue;
                }
            }
         
        }
    }
}
