using Atm.App;
using Atm.Functions;
using Atm.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//  CardOwner _gg = new CardOwner();
//string hh = _gg.ToString();

namespace Atm
{
    public class Program
    {
        static void Main(string[] args)
        {
            //public static string firstName;

            List<CardOwner> person = new List<CardOwner>();
            person.Add(new CardOwner() { FirstName = "rumeysa", LastName = "cetinkaya", CardNo = 12345, CardPın = 12348, Balance = 1255.5 });
            person.Add(new CardOwner() { FirstName = "ibrahim", LastName = "ocakcı", CardNo = 34567, CardPın = 3458, Balance = 2145 });
            person.Add(new CardOwner() { FirstName = "elif", LastName = "akca", CardNo = 56789, CardPın = 56788, Balance = 5152.7 });

            AppScreen.Welcome(); //Obje oluşturmadan classİsmi.Metodİsmi diyip çağırabiliyoruz

            //while (true)
            //{
                string firstName = Convert.ToString(Utility.UserInfo("First name: "));
                string lastName = Convert.ToString(Utility.UserInfo("Last name: "));
                //int i = 0;
                //if (person[i].FirstName == firstName && person[i].LastName == lastName)
                //{
                    //string[] x = { firstName , lastName };
                    //return x;
                    //break;
                //}
                //else
                //{
                //    continue;
                //}
            //}

            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].FirstName== firstName && person[i].LastName == lastName)
                {
                  //  while (true)  //doğru girene kadar card no pın isticektim ya da 3 hakkın olsun
                   // {
                        int cardNo = int.Parse(Utility.UserInfo("card number: "));
                        int cardPın = int.Parse(Utility.UserInfo("PIN: ")); ;
                   // }
                    if (cardNo == person[i].CardNo && cardPın == person[i].CardPın)
                    {
                        Console.Clear();
                        Console.WriteLine($"Welcome  {firstName} {lastName}. ");
                        Console.WriteLine("--------------------------------------");
                        int choice = AppScreen.Menu();
                        switch(choice)
                        {
                            case 1:
                                double balance = Withdrawal.WithdrawalFromCard(person[i].Balance);
                                Console.Clear();
                                Console.WriteLine($"Current balance is { balance }$ ");
                                break;
                            case 2:
                                double a = AddMoney.AddMoneyToCard(person[i].Balance);
                                Console.Clear();
                                Console.WriteLine($"Current balance is {a}$ ");
                                break;
                            case 3:
                                Console.WriteLine("You choose 3");
                                double y  = Withdrawal.WithdrawalFromCard(person[i].Balance);
                                Console.WriteLine("Current balance is { y } $");
                                break;
                            case 4:
                                LogOut.LogOutFromApp();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\nCard no and PIN isn't matching or one of them is wrong. Please try again...");
                        Thread.Sleep(1000);
                        break;  //continue diyemediğim için programı kapatıyorum
                       // continue;
                    }
                }
                else
                {
                    Console.WriteLine("\n\nWe don't have this member in our bank. The program is closing...");
                    Thread.Sleep(1200);
                    Environment.Exit(0);
                }
            }
            //Console.ReadLine();
        }
    }
}
