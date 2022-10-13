using Atm.App;
using Atm.Functions;
using Atm.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Atm
{
    public class Program
    {
        static void Main(string[] args)
        {
            int cardNo=0;  //card no pıni console den istediğim içeri alınca card
            int cardPın=0;
            int login = 3;



            List<CardOwner> person = new List<CardOwner>();
            person.Add(new CardOwner() { FirstName = "rumeysa", LastName = "cetinkaya", CardNo = 12345, CardPın = 12348, Balance = 1255.5 });
            person.Add(new CardOwner() { FirstName = "ibrahim", LastName = "ocakcı", CardNo = 34567, CardPın = 3458, Balance = 2145 });
            person.Add(new CardOwner() { FirstName = "elif", LastName = "akca", CardNo = 56789, CardPın = 56788, Balance = 5152.7 });

            AppScreen.Welcome();
            CardOwner per = new CardOwner();

            while (true)
            {
                string firstName = Convert.ToString(Utility.UserInfo("First name: "));
                string lastName = Convert.ToString(Utility.UserInfo("Last name: "));
                per = person.Find(p => p.FirstName == firstName && p.LastName == lastName); //bu isimde listede kişi varsa alıp yeni nesne içine at

                if (per != null)  // aldığımız veriler listemizdekilerde varsa işlemleri yapıyor ??????? 
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"----------------Welcome {per.FirstName} {per.LastName} ----------------------\n\n");
                        Console.WriteLine($"(You can only try {login} times.)\n");
                        cardNo = int.Parse(Utility.UserInfo("card number: "));   //card no-pın döngü içine atsam dışarda nasıl kullancam?????????
                        cardPın = int.Parse(Utility.UserInfo("PIN: "));
                        login--;
                        if (per.CardPın != cardPın && per.CardNo != cardNo)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nCard no and PIN isn't matching or one of them is wrong...");
                            Thread.Sleep(1000);
                            if (i < 2)
                            {
                                //login--;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"You have {login} left.Please try again");
                                Thread.Sleep(1300);
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\n\nThe program is closing...");
                                Thread.Sleep(1300);
                                Environment.Exit(0);
                            }
                        }
                        if (per.CardPın == cardPın && per.CardNo == cardNo) { break; }
                    }   //kullanıcıya şifresine 3 giriş hakkı tanımak için

                    Console.Clear();
                    Console.WriteLine($"----------------Welcome  {per.FirstName} {per.LastName}.----------------------");
                    int choice = AppScreen.Menu();

                    Choice.ByChoice(choice, per.Balance); //Menü den aldığımız seçimi metoda yolluyoruz ki switch-case işini yapsın
                }
                else /*if (cardNo != person[i].CardNo && cardPın != person[i].CardPın)*/
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nWe don't have this member in our bank. The program is closing..."); //for old için bir kere işlemleri yapıp 2.ye dönüyo(i++ old) ya da işlemleri yaptıktan sonra break dan dolayı ve burayı yazdırıyor
                    Thread.Sleep(1200);
                    Environment.Exit(0);

                    //Console.ReadLine();

                }  //isim soy isim yoksa listede kontrolü
            }
        }
    }
}
