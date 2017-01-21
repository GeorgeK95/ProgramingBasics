using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] numbersArray = input(n);
            double[] percentArrayResults = makeTheCalculations(numbersArray);
            output(percentArrayResults);
        }

        private static double[] makeTheCalculations(int[] numbersArray)
        {
            double[] percentArrayResults = new double[5];
            //double[] percT = new double[5];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] < 200)
                {
                    percentArrayResults[0] ++;
                }
                else if (numbersArray[i] < 400)
                {
                    percentArrayResults[1] ++;
                }
                else if (numbersArray[i] < 600)
                {
                    percentArrayResults[2]++;
                }
                else if (numbersArray[i] < 800)
                {
                    percentArrayResults[3]++;
                }
                else if (numbersArray[i] >= 800)
                {
                    percentArrayResults[4]++;
                }
                //Console.WriteLine("test" + percentArrayResults[4]);
               
            }
            percentArrayResults = makeThemInPercent(percentArrayResults, numbersArray.Length);
            for (int i = 0; i < percentArrayResults.Length; i++)
            {
               // Console.WriteLine("vrashta li be?" + percT[i]);
            }
            return percentArrayResults;
        }

        private static double[] makeThemInPercent(double[] percentArrayResults, int n)
        {
            for (int i = 0; i < percentArrayResults.Length; i++)
            {
                percentArrayResults[i] = (percentArrayResults[i] / n) * 100;
            }
            return percentArrayResults;
        }

        private static void output(double[] percentArrayResult)
        {
            for (int i = 0; i < percentArrayResult.Length; i++)
            {
                percentArrayResult[i] /= 100;
                Console.WriteLine("{0:P}", percentArrayResult[i]);
            }
        }

        private static int[] input(int n)
        {
            int[] numArray = new int[n];

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            return numArray;
        }
    }
}
