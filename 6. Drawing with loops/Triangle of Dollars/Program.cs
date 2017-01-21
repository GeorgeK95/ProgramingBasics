using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int i1 = 0; i1 < i; i1++)
                {
                    Console.Write("$ ");
                    //Console.Write(' ');
                } Console.WriteLine();
                //i++;

            }

        }
    }
}
