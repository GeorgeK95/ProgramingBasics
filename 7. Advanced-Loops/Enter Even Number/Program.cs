using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter even number: ");
                    int num = int.Parse(Console.ReadLine());
                    if (isEvenCheck(num))
                    {
                        Console.WriteLine("Even number entered: " + num);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch 
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }

        private static bool isEvenCheck(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
