using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var examStartHour = int.Parse(Console.ReadLine());
            var examStartMinute = int.Parse(Console.ReadLine());
            var arriveHour = int.Parse(Console.ReadLine());
            var arriveMinute = int.Parse(Console.ReadLine());

            int examTime = examStartHour * 60 + examStartMinute;
            int arriveTime = arriveHour * 60 + arriveMinute;

            int difference = arriveTime - examTime;

            int differenceHours = difference / 60;
            int differenceMinutes = difference % 60;

            if (difference > 0)
            {
                Console.WriteLine("Late");
                printLateInfo(differenceHours, differenceMinutes);
            }
            else if (difference <= 0 && difference >= -30)
            {
                Console.WriteLine("On time");
                differenceHours = Math.Abs(differenceHours);
                differenceMinutes = Math.Abs(differenceMinutes);
                printEarlyInfo(differenceHours, differenceMinutes);
            }
            else
            {
                Console.WriteLine("Early");
                differenceHours = Math.Abs(differenceHours);
                differenceMinutes = Math.Abs(differenceMinutes);
                printEarlyInfo(differenceHours, differenceMinutes);
            }
        }
        private static void printEarlyInfo(int differenceHours, int differenceMinutes)
        {

            if (differenceHours == 0)
            {
                Console.WriteLine(differenceMinutes + " minutes before the start");
            }
            else
            {
                if (differenceMinutes < 10)
                {
                    Console.WriteLine(differenceHours + ":0" + differenceMinutes + " hours before the start");
                }
                else
                {
                    Console.WriteLine(differenceHours + ":" + differenceMinutes + " hours before the start");
                }
            }
        }
        private static void printLateInfo(int differenceHours, int differenceMinutes)
        {
            if (differenceHours == 0)
            {
                Console.WriteLine(differenceMinutes + " minutes after the start");
            }
            else
            {
                if (differenceMinutes < 10)
                {
                    Console.WriteLine(differenceHours + ":0" + differenceMinutes + " hours after the start");
                }
                else
                {
                    Console.WriteLine(differenceHours + ":" + differenceMinutes + " hours after the start");
                }
            }
        }
    }
}