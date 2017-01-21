using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
/*7
34
-33
52
12
-32
32
23
41
7
25
34
23
124
21*/
    class Program
    {
        static void Main(string[] args)
        {
            var numOfPairs = int.Parse(Console.ReadLine());
            int maxDiff = 0;

            for (int i = 1; i <= numOfPairs; i++)
            {
                 maxDiff -= getCoupleSum();
                //int coupleSum2 = getCoupleSum();


            }
        }

        private static int getCoupleSum()
        {
            int coupleSum = 0;
            for (int i = 0; i < 2; i++)
            {
                var num = int.Parse(Console.ReadLine());
                coupleSum += num;
            }
            return coupleSum;
        }
    }
}
