using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5,2,4,0 };
            char a = '\0';
            Console.WriteLine(a);
            int counter = 1;
            int best = 1;
            int i = 0;

            while (arr[i] != 0)
            {
                if (arr[i] < arr[i + 1])
                {
                    counter++;
                    if (counter > best)
                    {
                        best = counter;
                    }
                }

                else
                {
                    counter = 0;
                }
                i++;
            }
            {
                
            }
            /*if (check == false)
	        {
                Console.WriteLine(best + 1);
	        }
            else
            {
                Console.WriteLine(best + 1);
            }*/
            Console.WriteLine(best + 1);
            
        }
    }
}
