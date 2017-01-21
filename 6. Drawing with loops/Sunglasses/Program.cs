using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int rowFrame;

            if (n % 2 == 0)
            {
                rowFrame = n / 2 - 1;   
            }
            else
            {
                rowFrame = n / 2;
            }
            for (int rows = 0; rows < n; rows++)
            {
                if (rows == 0 || rows == n - 1)
                {
                    for (int symbols = 0; symbols < 5 * n; symbols++)
                    {
                        if (symbols < (4 * n) / 2 || symbols >= (4 * n) / 2 + n)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();    
                }
                else
                {
                    for (int symbols = 0; symbols < 5 * n; symbols++)
                    {
                        if (symbols == 0 || symbols == (5 * n) - 1 || symbols == (4 * n) / 2 - 1 || symbols == (4 * n) / 2 + n)
                        {
                            Console.Write("*");
                        }
                        else if (!(symbols < (4 * n) / 2 || symbols >= (4 * n) / 2 + n))
                        {
                            if (rows == rowFrame)
                            {
                                Console.Write("|");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else
                        {
                            Console.Write("/");
                        }            
                    }
                    Console.WriteLine();
                }   
            }
        }
    }
}
