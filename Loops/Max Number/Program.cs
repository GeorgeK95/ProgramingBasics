using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfNumbers = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;

            if (numberOfNumbers > 0)
            {
                for (int i = 0; i < numberOfNumbers; i++)
                {
                    var number = int.Parse(Console.ReadLine());
                    if (number > maxValue)
                    {
                        maxValue = number;
                    }
                }
                Console.WriteLine(maxValue);
            }
            else
            {
                Console.WriteLine("Error. N must be greather than 0.");
            }
        }
    }
}
