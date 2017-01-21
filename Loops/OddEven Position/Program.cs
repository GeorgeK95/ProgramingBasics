using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double OddSum = 0, OddMin = 1000000000.0, OddMax = -1000000000.0, EvenSum = 0, EvenMin = 1000000000.0, EvenMax = -1000000000.0;

            for (int i = 1; i <= n; i++)
            {
                var input = double.Parse(Console.ReadLine());
                if (i % 2 != 0) //odd
                {
                    OddSum += input;
                    if (input < OddMin)
                    {
                        OddMin = input;
                    }
                    if (input > OddMax)
                    {
                        OddMax = input;
                    }
                }
                else //even - 4etno
                {
                    EvenSum += input;
                    if (input < EvenMin)
                    {
                        EvenMin = input;
                    }
                    if (input > EvenMax)
                    {
                        EvenMax = input;
                    }
                }
            }
            Console.WriteLine("OddSum=" + OddSum + ",");

            if (OddMin == 1000000000.0)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine("OddMin=" + OddMin + ",");
            }
            if (OddMax == -1000000000.0)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMax=" + OddMax + ",");
            }
            Console.WriteLine("EvenSum=" + EvenSum + ",");
            if (EvenMin == 1000000000.0)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine("EvenMin=" + EvenMin + ",");
                //1000000000.0
            }
            if (EvenMax == -1000000000.0)
            {
                Console.WriteLine("EvenMax=No,");
            }
            else
            {
                Console.WriteLine("EvenMax=" + EvenMax);
            }
            //Console.WriteLine("OddSum=" + OddSum + ",\nOddMin=" + OddMin + ",\nOddMax=" + OddMax
               // + ",\nEvenSum=" + EvenSum + ",\nEvenMin=" + EvenMin + ",\nEvenMax=" + EvenMax);
        }
    }
}