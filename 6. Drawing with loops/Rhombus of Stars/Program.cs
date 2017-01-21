using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int i1 = i; i1 <= num - 1; i1++)
                {
                    Console.Write(" ");
                }
                for (int i2 = 0; i2 < i; i2++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
            
            for (int i = 1; i <= num - 1; i++)
            {
                for (int i1 = 0; i1 < i; i1++)
                {
                    Console.Write(" ");
                }
                for (int i2 = i; i2 < num; i2++)
                {
                    Console.Write("* ");    
                }
                
                Console.WriteLine();
            }
            

        }    
    }
}
