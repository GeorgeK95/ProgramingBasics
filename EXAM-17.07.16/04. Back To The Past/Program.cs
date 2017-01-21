using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            int chetniGodini = 0;
            int neChetniGodini = 0;
            int coef = 0;
            int cc = 17;

            for (int i = 1800; i <= year; i++)
            {
                cc++;
                if (i % 2 == 0) //4etna godina
                {
                    chetniGodini++;
                }
                else //ne4etna takava
                {
                    neChetniGodini++;
                    coef += cc;
                }
            }

            int razhodiChetniGodini = chetniGodini * 12000;
            int razhodiNechetniGodini = neChetniGodini * 12000;
            razhodiNechetniGodini += coef * 50;

            int totalRazhodi = razhodiNechetniGodini + razhodiChetniGodini;

            if (money >= totalRazhodi)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0} dollars left.", string.Format("{0:0.00}", money - totalRazhodi));
            }
            else
            {
                Console.WriteLine("He will need {0} dollars to survive.", string.Format("{0:0.00}", totalRazhodi - money));
            }
        }
    }
}
