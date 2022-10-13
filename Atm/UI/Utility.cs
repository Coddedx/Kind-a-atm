using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.UI
{
    internal class Utility
    {
        //card no ve pin i alabilmek için x
        public static string UserInfo(string x)
        {
            Console.Write($"Please enter your { x } ");   //ana koddan card no ya da pin gir diye göndercez sadece
            return Console.ReadLine();
        }

        public static int Money(string n)
        {
            Console.WriteLine($"How much money do you wanna {n} ");   

            string _charList = Console.ReadLine();  // Burda consola girilenleri char olarak alıp sayıya öyle çeviriyorum ki sadece sayı giriliyorsa işlemleri yapabilsin
            string _money = "" ;
            
            foreach (char c in _charList)
            {
                if (c>=48 && c<=57)
                {
                    string _m=c.ToString() ;
                    _money += _m;
                    continue;
                }
                else
                {
                    Console.WriteLine("\nPara girişi doğru değildir. Consolu kapatıyorum...");
                    Thread.Sleep(1300);
                    Environment.Exit(0);
                }
              
            }
            return int.Parse(_money);     
        }
    }
}
