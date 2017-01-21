using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var symbol = char.Parse(Console.ReadLine());
            int result = 0;

            if (symbol.Equals('+') || symbol.Equals('-') || symbol.Equals('*'))
            {
                if (symbol.Equals('+'))
                {
                    result = num1 + num2;
                }
                else if (symbol.Equals('-'))
                {
                    result = num1 - num2;
                }
                else
                {
                    result = num1 * num2;
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, symbol, num2, result, isEven(result));
            }
            else if (symbol.Equals('/'))
            {
                if (num2 == 0)
                { 
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    double n1 = Convert.ToDouble(num1);
                    double n2 = Convert.ToDouble(num2);
                    double result1 = n1 / n2;
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, result1);
                }
            }
            else if (symbol.Equals('%'))
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine("{0} % {1} = {2}", num1, num2, result);
                }
            }
        }

        private static double tapotiqDo6iq(double result)
        {
            string resultStr = result.ToString();
            char[] resultArr = resultStr.ToCharArray();
            string returnStr = "";

            for (int i = 0; i < resultArr.Length; i++)
            {
                if (resultArr[i].Equals(','))
                {
                    resultArr[i] = '.';
                }    
            }
            for (int i = 0; i < resultArr.Length; i++)
            {
                returnStr += resultArr[i];
            }
            return Convert.ToDouble(returnStr);
        }

        private static string isEven(int number)
        {
            string result;

            if (number % 2 == 0)
            {
                result = "even";
            }
            else
            {
                result = "odd";
            }
            return result;
        }*/
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var oper = Console.ReadLine();
            var resAdd = n1 + n2;       // +  
            var resSubs = n1 - n2;      // -
            var resMult = n1 * n2;      // *
            var resDiv = (double)n1 / n2;       // /
            var resMod = (double)n1 % n2;       // %
            string oddOrEven = "";
            switch (oper)
            {
                case "+":
                    if (resAdd % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine("{0} " + oper + " {1} = {2} - " + oddOrEven, n1, n2, resAdd);
                    break;
                case "-":
                    if (resSubs % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine("{0} " + oper + " {1} = {2} - " + oddOrEven, n1, n2, resSubs);
                    break;
                case "*":
                    if (resMult % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine("{0} " + oper + " {1} = {2} - " + oddOrEven, n1, n2, resMult);
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine("{0} " + oper + " {1} = {2:0.00}", n1, n2, resDiv);
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine("{0} " + oper + " {1} = {2}", n1, n2, resMod);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
