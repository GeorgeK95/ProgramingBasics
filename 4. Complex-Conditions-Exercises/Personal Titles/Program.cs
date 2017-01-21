using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program

       /* •	“Mr.” – мъж(пол “m”) на 16 или повече години
•	“Master” – момче(пол “m”) под 16 години
•	“Ms.” – жена(пол “f”) на 16 или повече години
•	“Miss” – момиче(пол “f”) под 16 години*/

    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = char.Parse(Console.ReadLine());

            if (gender.Equals('m'))
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                    Console.WriteLine("Master");
            }
            else 
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                    Console.WriteLine("Miss");
            }
        }
    }
}
