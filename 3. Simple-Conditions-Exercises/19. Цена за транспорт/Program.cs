using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Цена_за_транспорт
{
    class Program
    {
        static void Main(string[] args)
        {
            var kilometers = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();
            double resultTaxi = 0;
            double resultBus = 0;
            double resultTrain = 0;

            if (kilometers < 20)
            {
                if (time.Equals("day"))
                {
                    resultTaxi = kilometers * 0.79;
                    resultTaxi += 0.70;
                }
                else
                {
                    resultTaxi = kilometers * 0.90;
                    resultTaxi += 0.70;
                }
                Console.WriteLine(resultTaxi);
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                if (time.Equals("day"))
                {
                    resultTaxi = kilometers * 0.79;
                    resultTaxi += 0.70;
                }
                else
                {
                    resultTaxi = kilometers * 0.90;
                    resultTaxi += 0.70;
                }
                resultBus = kilometers * 0.09;
                if (resultTaxi < resultBus)
                {
                    Console.WriteLine(resultTaxi);
                }
                else
                {
                    Console.WriteLine(resultBus);
                }
            }
            else
            {
                if (time.Equals("day"))
                {
                    resultTaxi = kilometers * 0.79;
                    resultTaxi += 0.70;
                }
                else
                {
                    resultTaxi = kilometers * 0.90;
                    resultTaxi += 0.70;
                }
                resultBus = kilometers * 0.09;
                resultTrain = kilometers * 0.06;
                Console.WriteLine(findSmallest(resultTaxi, resultBus, resultTrain)); 
            }
        }

        private static double findSmallest(double resultTaxi, double resultBus, double resultTrain)
        {
            double[] arr = new double[] {resultTaxi, resultBus, resultTrain};
            double min = resultTaxi;
            for (int i = 0; i < 3; i++)
            { 
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
