using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfInputs = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxValue = int.MinValue;

            for (int i = 0; i < numberOfInputs; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxValue)
                {
                    maxValue = num;
                }
            }

            if (sum - maxValue == maxValue)
            {
                Console.WriteLine("Yes\nSum = " + maxValue);
            }
            else
            {
                sum -= maxValue;
                Console.WriteLine("No\nDiff = " + Math.Abs(maxValue - sum));
            }
        }
    }
}
