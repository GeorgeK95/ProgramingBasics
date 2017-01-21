using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int prevNum = int.MinValue;
            int c = 0;
            int bestScore = 0;

            for (int i = 1; i <= n; i++)
            {
                var currNum =  int.Parse(Console.ReadLine());

                if (currNum > prevNum)
                {
                    c++;
                }
                else
                {
                    c = 1;
                }

                if (c > bestScore)
                {
                    bestScore = c;
                }
                prevNum = currNum;

            }
            Console.WriteLine(bestScore);
        }
    }
}
