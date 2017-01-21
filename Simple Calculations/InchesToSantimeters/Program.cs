using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToSantimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter inches: ");
            var inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch * 2.54);
        }
    }
}
