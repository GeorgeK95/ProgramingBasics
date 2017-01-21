using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

           /* if (V < 1 || V > 10000 || P1 < 1 || P1 > 5000 || P2 < 1 || P2 > 5000 || H < 1 || H > 24)
            {
                Console.WriteLine("Incorrect data");
            }*/
            //else
            //{
                if (V - H * (P1 + P2) >= 0)
                {
                    double V1 = H * (P1 + P2);//660
                    double VPercent = V1 / V; VPercent *= 100;
                double pipe1Percent = H * P1 / V1; pipe1Percent *= 100;
                double pipe2Percent = H * P2 / V1; pipe2Percent *= 100;
                    Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", (int) VPercent, (int) pipe1Percent, (int) pipe2Percent);
                }
                else
                {
                    Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, H * (P1 + P2) - V);
                }
            //}
        }
    }
}
