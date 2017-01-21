using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*•	Плодовете "fruit" са banana, apple, kiwi, cherry, lemon и grapes
•	Зеленчуците "vegetable" са tomato, cucumber, pepper и carrot
•	Всички останали са "unknown"
*/

            var input = Console.ReadLine().ToLower();

            if (input.Equals("banana") || input.Equals("apple") || input.Equals("kiwi") || input.Equals("cherry") || input.Equals("lemon") || input.Equals("grapes"))
            {
                Console.WriteLine("fruit");
            }
            else if (input.Equals("tomato") || input.Equals("cucumber") || input.Equals("pepper") || input.Equals("carrot"))
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
          
        }
    }
}
