using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if (character.Equals('a'))
                {
                    result += 1;
                }
                else if (character.Equals('e'))
                {
                    result += 2;
                }
                else if (character.Equals('i'))
                {
                    result += 3;
                }
                else if (character.Equals('o'))
                {
                    result += 4;
                }
                else if (character.Equals('u'))
                {
                    result += 5;
                }
                else
                {
                    result += 0;
                }
            }

            Console.WriteLine(result);
        }
    }
}
