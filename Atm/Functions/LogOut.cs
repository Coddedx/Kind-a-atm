using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.Functions
{
    internal class LogOut
    {       
        public static void LogOutFromApp()
        {
            Console.Clear();
            Console.WriteLine("--------------------WELCOME----------------------");
            Console.WriteLine("You choice 4 \n");
            Console.WriteLine("Program is closing. I'm giving your credit card. See you soon!");
            Thread.Sleep(2000);

        }
    }
}
