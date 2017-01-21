using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool ch = true;

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.Write("+ ");
                    ch = true;
                }
                else
                {
                    Console.Write("| ");
                    ch = false;
                }
                for (int j = 1; j < n - 1; j++)
                {
                    //if (ch)
	                //{
		                Console.Write("- ");
	                //}
                }
                if (ch)
                {
                    Console.Write("+");                    
                }
                else
                {
                    Console.Write("|");
                }
               Console.WriteLine();
            }
        }
    }
}
