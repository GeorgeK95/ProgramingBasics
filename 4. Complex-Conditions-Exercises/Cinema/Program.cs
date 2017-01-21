using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    /*на различни цени:
•	Premiere – премиерна прожекция, на цена 12.00 лева.
•	Normal – стандартна прожекция, на цена 7.50 лева.
•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
*/
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            double result = rows * cols;

            if (type.Equals("Premiere"))
            {
                Console.WriteLine(result * 12);
            }
            else if (type.Equals("Normal"))
            {
                Console.WriteLine(result * 7.5);
            }
            else
            {
                Console.WriteLine(result * 5);
            }
        }
    }
}
