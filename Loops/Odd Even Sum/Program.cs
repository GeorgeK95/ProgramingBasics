using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfInputs = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;//4etno

            for (int i = 1; i <= numberOfInputs; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (i % 2 != 0) //ne4etno
                {
                    oddSum += num;
                }
                else
                {
                    evenSum += num;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes\nSum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No\nDiff = " + Math.Abs(oddSum - evenSum));
            }
        }
    }
}
