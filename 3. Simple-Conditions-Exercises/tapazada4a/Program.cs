using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapazada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string edinicaResult = null;
            string deseticaResult = null;

            if (num < 0 || num > 100)
            {
                Console.WriteLine("invalid number");
            }

            else
            {
                if (num < 10)
                {
                    int edinica = num;
                    if (edinica == 0)
                    {
                        edinicaResult = "zero";
                    }
                    else if (edinica == 1)
                    {
                        edinicaResult = "one";
                    }
                    else if (edinica == 2)
                    {
                        edinicaResult = "two";
                    }
                    else if (edinica == 3)
                    {
                        edinicaResult = "three";
                    }
                    else if (edinica == 4)
                    {
                        edinicaResult = "four";
                    }
                    else if (edinica == 5)
                    {
                        edinicaResult = "five";
                    }
                    else if (edinica == 6)
                    {
                        edinicaResult = "six";
                    }
                    else if (edinica == 7)
                    {
                        edinicaResult = "seven";
                    }
                    else if (edinica == 8)
                    {
                        edinicaResult = "eight";
                    }
                    else if (edinica == 9)
                    {
                        edinicaResult = "nine";
                    }
                    Console.WriteLine(edinicaResult);
                }
                else if (num >= 10 && num <= 20)
                {
                    if (num == 10)
                    {
                        Console.WriteLine("ten");
                    }
                    else if (num == 11)
                    {
                        Console.WriteLine("eleven");
                    }
                    else if (num == 12)
                    {
                        Console.WriteLine("twelve");
                    }
                    else if (num == 13)
                    {
                        Console.WriteLine("thirteen");
                    }
                    else if (num == 14)
                    {
                        Console.WriteLine("fourteen");
                    }
                    else if (num == 15)
                    {
                        Console.WriteLine("fifteen");
                    }
                    else if (num == 16)
                    {
                        Console.WriteLine("sixteen");
                    }
                    else if (num == 17)
                    {
                        Console.WriteLine("seventeen");
                    }
                    else if (num == 18)
                    {
                        Console.WriteLine("eighteen");
                    }
                    else if (num == 19)
                    {
                        Console.WriteLine("nineteen");
                    }
                    else if (num == 20)
                    {
                        Console.WriteLine("twenty");
                    }
                }
                else
                {
                    if (num == 100)
                    {
                        Console.WriteLine("one hundred");
                    }
                    else
                    {
                        int edinica = num % 10;
                        int desetica = num / 10;
                        if (edinica == 1)
                        {
                            edinicaResult = "one";
                        }
                        else if (edinica == 2)
                        {
                            edinicaResult = "two";
                        }
                        else if (edinica == 3)
                        {
                            edinicaResult = "three";
                        }
                        else if (edinica == 4)
                        {
                            edinicaResult = "four";
                        }
                        else if (edinica == 5)
                        {
                            edinicaResult = "five";
                        }
                        else if (edinica == 6)
                        {
                            edinicaResult = "six";
                        }
                        else if (edinica == 7)
                        {
                            edinicaResult = "seven";
                        }
                        else if (edinica == 8)
                        {
                            edinicaResult = "eight";
                        }
                        else if (edinica == 9)
                        {
                            edinicaResult = "nine";
                        }


                        if (desetica == 2)
                        {
                            deseticaResult = "twenty";
                        }
                        if (desetica == 3)
                        {
                            deseticaResult = "thirty";
                        }
                        if (desetica == 4)
                        {
                            deseticaResult = "fourty";
                        }
                        if (desetica == 5)
                        {
                            deseticaResult = "fifty";
                        }
                        if (desetica == 6)
                        {
                            deseticaResult = "sixty";
                        }
                        if (desetica == 7)
                        {
                            deseticaResult = "seventy";
                        }
                        if (desetica == 8)
                        {
                            deseticaResult = "eighty";
                        }
                        if (desetica == 9)
                        {
                            deseticaResult = "ninety";
                        }
                        if (num == 30)
                        {
                            Console.WriteLine("thirty");
                        }
                        else if (num == 50)
                        {
                            Console.WriteLine("fifty");
                        }

                        else
                        {
                            if (num > 20)
                            {
                                Console.WriteLine(deseticaResult + " " + edinicaResult);
                            }
                            else
                            {
                                Console.WriteLine(deseticaResult + edinicaResult);
                            }
                        }
                        
                       
                    }
                }

            }

        }
    }
}
