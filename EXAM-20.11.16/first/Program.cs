using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceMackerel = double.Parse(Console.ReadLine());//skumriq
            double priceSprat = double.Parse(Console.ReadLine());//caca
            double kilosBelted = double.Parse(Console.ReadLine());//kilograma palamud
            double kilosScad = double.Parse(Console.ReadLine());//kilograma safrid
            int kilosClams = int.Parse(Console.ReadLine());//kilograma MIDI

            double priceBelted = 0.6 * priceMackerel + priceMackerel;
            double priceScad = 0.8 * priceSprat + priceSprat;
            double priceClams = 7.50;

            double totalbelted = priceBelted * kilosBelted;//palamud
            double totalScad = kilosScad * priceScad;//safrid
            double totalClams = kilosClams * priceClams;//midi

            Console.WriteLine("{0:0.00}", Math.Round((totalbelted + totalClams + totalScad), 2));


            //Console.WriteLine(Math.Round(priceScad + pri));

        }
    }
}
