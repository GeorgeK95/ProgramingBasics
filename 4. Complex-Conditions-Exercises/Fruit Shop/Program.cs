using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            Boolean isWeekDay = true;
            if (day.Equals("monday") || day.Equals("Tuesday ") || day.Equals("Wednesday ") || day.Equals("Thursday ") || day.Equals("friday"))
            {
                isWeekDay = true;
            }
            else if (day.Equals("saturday") || day.Equals("sunday"))
            {
                isWeekDay = false;
            }
            else
            {
                Console.WriteLine("error");
            }
            if (isWeekDay == true)
            {
                if (fruit.Equals("banana"))
                {
                    Console.WriteLine(quantity * 2.50);
                }
                else if (fruit.Equals("apple"))
                {
                    Console.WriteLine(quantity * 1.20);
                }
                else if (fruit.Equals("orange"))
                {
                    Console.WriteLine(quantity * 0.85);
                }
                else if (fruit.Equals("grapefruit"))
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (fruit.Equals("kiwi"))
                {
                    Console.WriteLine(quantity * 2.70);
                }
                else if (fruit.Equals("pineapple"))
                {
                    Console.WriteLine(quantity * 5.50);
                }
                else if (fruit.Equals("grapes"))
                {
                    Console.WriteLine(quantity * 3.85);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (isWeekDay == false)
            {
                if (fruit.Equals("banana"))
                {
                    Console.WriteLine(quantity * 2.70);
                }
                else if (fruit.Equals("apple"))
                {
                    Console.WriteLine(quantity * 1.25);
                }
                else if (fruit.Equals("orange"))
                {
                    Console.WriteLine(quantity * 0.90);
                }
                else if (fruit.Equals("grapefruit"))
                {
                    Console.WriteLine(quantity * 1.60);
                }
                else if (fruit.Equals("kiwi"))
                {
                    Console.WriteLine(quantity * 3.0);
                }
                else if (fruit.Equals("pineapple"))
                {
                    Console.WriteLine(quantity * 5.60);
                }
                else if (fruit.Equals("grapes"))
                {
                    Console.WriteLine(quantity * 4.20);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}
