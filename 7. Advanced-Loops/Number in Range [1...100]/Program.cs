using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("Еnter a number in the range[1...100]: ");
                n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 100)
                {
                    Console.WriteLine("The number is: " + n);
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            } while (n < 1 || n > 100);
        }
    }
}
