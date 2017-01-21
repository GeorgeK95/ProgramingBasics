using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsium_Farehnait
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsuium = double.Parse(Console.ReadLine());

            Console.WriteLine((celsuium * 1.8) + 32);
        }
    }
}
