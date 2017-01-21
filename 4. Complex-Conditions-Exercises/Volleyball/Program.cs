using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var leap = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());//games in his own town

            int sofiaWeekends = 48 - h;//46
            double gamesInSofia = sofiaWeekends * (3.0 / 4.0);//34.5
            double gamesInHolidayDays = p * (2.0 / 3.0);//3.3333
            double result = gamesInHolidayDays + gamesInSofia + h;
            Console.WriteLine(result + "assa");
            double bonus = 0;

            if (leap.Equals("leap"))
            {
                bonus = result * 0.15;
                Console.WriteLine(Math.Truncate(result + bonus));
            }
            else
                Console.WriteLine(Math.Truncate(result));
            
        }
    }
}
