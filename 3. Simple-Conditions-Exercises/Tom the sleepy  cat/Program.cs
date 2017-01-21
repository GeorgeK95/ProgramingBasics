using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_the_sleepy__cat
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            int restDays = 365 - days;
            int minutesPlay = (days * 127) + (restDays * 63);
           // Console.WriteLine(minutesPlay);
            if (minutesPlay < 30000)
            {
                minutesPlay = 30000 - minutesPlay;
                //Console.WriteLine(minutesPlay);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", minutesPlay / 60, minutesPlay % 60);

            }
            else
            {
                minutesPlay = minutesPlay - 30000;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", minutesPlay / 60, minutesPlay % 60);

            }
        }
    }
}
