using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            /*•	На първия ред – периода, за който трябва да направите изчисления. Цяло число в интервала [1 ... 1000]
•	На следващите редове(равни на броят на дните) – броя пациенти, които пристигат за преглед за текущия ден. Цяло число в интервала [0…10 000]
*/

            var period = int.Parse(Console.ReadLine());
            int pregledani = 0;
            int nepregledani = 0;
            int doctors = 7;

            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0)
                {
                    if (pregledani < nepregledani)
                    {
                        doctors++;
                    }
                }
                var numOfPacients = int.Parse(Console.ReadLine());
                if (numOfPacients < doctors)
                {
                    pregledani += numOfPacients;
                   // nepregledani += 0;
                }
                else if (numOfPacients >= doctors)
                {
                    pregledani += doctors;
                    nepregledani += numOfPacients - doctors;
                }
            }
            Console.WriteLine("Treated patients: {0}.\nUntreated patients: {1}.", pregledani, nepregledani);
        }
    }
}
