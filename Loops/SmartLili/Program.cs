using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            var liliAge = int.Parse(Console.ReadLine());
            var washPrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            int toyCountYears = calculateToyCountDays(liliAge); //Console.WriteLine("toycountyears: \t" + toyCountYears);
            int moneyCountYears = calculateMoneyCountDays(liliAge);

            int soldToysMoney = toyPrice * toyCountYears;
            int savedMoney = calculateSavedMoney(moneyCountYears);
         //   Console.WriteLine("soldtoysmoney: \t" + soldToysMoney);
           // Console.WriteLine("saved money: \t" + savedMoney);

            int brotherTokenMoney = moneyCountYears * 1;// Console.WriteLine("brother:\t" + brotherTokenMoney);
            int totalMoney = savedMoney + soldToysMoney - brotherTokenMoney;
           // Console.WriteLine("totalmoney: \t" + totalMoney);
            if (totalMoney >= washPrice)
            {
                Console.WriteLine("Yes! {0:0.00}", totalMoney - washPrice);
            }
            else
            {
                Console.WriteLine("No! {0:0.00}", Math.Abs(washPrice - totalMoney));
            }
        }

        private static int calculateSavedMoney(int moneyCountDays)
        {
            int savedMoney = 0;

            for (int i = 1; i <= moneyCountDays; i++)
            {
                savedMoney += i * 10;
            }
          //  Console.WriteLine("savedm" + savedMoney);
            return savedMoney;
        }

        private static int calculateMoneyCountDays(int liliAge)
        {
            int counter = 0;

            for (int i = 1; i <= liliAge; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        private static int calculateToyCountDays(int age)
        {
            int counter = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
