using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            /*•	dog -> mammal
•	crocodile, tortoise, snake -> reptile
•	others -> unknown
*/

            var animal = Console.ReadLine();

            if (animal.Equals("dog"))
            {
                Console.WriteLine("mammal");
            }
            else if (animal.Equals("crocodile") || animal.Equals("tortoise") || animal.Equals("snake"))
            {
                Console.WriteLine("reptile");
            }
            else
                Console.WriteLine("unknown");
        }
    }
}
