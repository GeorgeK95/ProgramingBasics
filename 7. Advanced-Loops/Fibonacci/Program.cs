using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int c = 1;
            bool ch = false;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (c == n + 1)
                    {
                        ch = true;
                        break;
                    }
                    Console.Write(c + " "); c++;
                    
                }
                if (ch)
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                }
                
            }
        }
    }
}
