using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfInputs = int.Parse(Console.ReadLine());
            int result = 0;
            int output = 0;

           // if (numberOfInputs % 2 != 0 || numberOfInputs == 0)
            //{
           //     Console.WriteLine("You must enter even number.");
           // }
           // else
           // {
                for (int i = 1; i <= numberOfInputs * 2; i++)
                {
                    var num = int.Parse(Console.ReadLine());

                    if (i <= numberOfInputs)
                    {
                        result += num;
                        output = result;
                    }
                    else
                    {
                        result -= num;
                    }

                }
                if (result == 0)
                {
                    Console.WriteLine("Yes, sum = " + output);
                }
                else
                {
                    Console.WriteLine("No, diff = " + Math.Abs(result));
                }
            //}
        }
    }
}
