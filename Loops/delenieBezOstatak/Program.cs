using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delenieBezOstatak
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] numbers = input(n);
            double[] results = makeCalculations(numbers);
            output(results);
        }

        private static void output(double[] results)
        {
            String a = "";
            for (int i = 0; i < results.Length; i++)
            {
                results[i] /= 100;
                a += string.Format("{0:P}", results[i]);
                a = removeEmptyPlases(a);
                //Console.WriteLine("{0:P}", results[i]);
                Console.WriteLine(a);
                a = "";
            }
        }

        private static String removeEmptyPlases(string a)
        {
            string ret = "";
            char[] aArray = new char[a.Length];
            aArray = a.ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                if (aArray[i] != ' ')
                {
                    ret += aArray[i];
                }
            }

            return ret;
        }

        private static double[] makeCalculations(int[] numbers)
        {
            double[] satisfactArray = new double[3];
           // double[] percArray = new double[satisfactArray.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    satisfactArray[0]++;
                }
                if (numbers[i] % 3 == 0)
                {
                    satisfactArray[1]++;
                }
                if (numbers[i] % 4 == 0)
                {
                    satisfactArray[2]++;
                }
            }
            satisfactArray = turnToPercent(satisfactArray, numbers.Length);
            return satisfactArray;
        }

        private static double[] turnToPercent(double[] satisfactArray, int n)
        {
          //  double[] percArr = new double[satisfactArray.Length];

            for (int i = 0; i < satisfactArray.Length; i++)
            {
                satisfactArray[i] = (satisfactArray[i] / n) * 100;
            }

            return satisfactArray;
        }

        private static int[] input(int n)
        {
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }
    }
}
