using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FruitWebGame.Controllers
{
    public class HomeController : Controller
    {
        static int rowsCount = 3;
        static int cowsCount = 9;
        static string[,] fruits = GenerateFruits();
        static int score = 0;
        bool isOver = false;

        private static string[,] GenerateFruits()
        {
            Random rand = new Random();
            fruits = new string[rowsCount, cowsCount];
            var num = 0;

            for (var row = 0; row < rowsCount; row++)
            {
                for (var cow = 0; cow < cowsCount; cow++)
                {
                    num = rand.Next(9);
                    if (num < 2)
                    {
                        fruits[row, cow] = "apple";
                    }
                    else if (num < 4)
                    {
                        fruits[row, cow] = "banana";
                    }
                    else if (num < 6)
                    {
                        fruits[row, cow] = "orange";
                    }
                    else if (num < 8)
                    {
                        fruits[row, cow] = "kiwi";
                    }
                    else 
                    {
                        fruits[row, cow] = "dynamite";
                    }
                }
            }
            return fruits;
        }
        public ActionResult Index()
        {
            ViewBag.rows = rowsCount;
            ViewBag.cows = cowsCount;
            ViewBag.fruits = fruits;
            ViewBag.score = score;
            ViewBag.isOver = isOver;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult FireTop(int position)
        {
            return Fire(position, 0, 1);
        }

        public ActionResult FireBottom(int position)
        {
            return Fire(position, rowsCount - 1,  - 1);
        }
        public ActionResult NewGame()
        {
            fruits = GenerateFruits();
            score = 0;
            isOver = false;
            return RedirectToAction("Index");
        }
        public ActionResult Fire(int position, int startRow, int step)
        {
            var col = position * (rowsCount - 1) / 100;
            var row = startRow;

            while (row >=0 && row < rowsCount)
            {
                var fruit = fruits[row, col];
                if (fruit == "apple" || fruit == "banana" || fruit == "orange" || fruit == "kiwi")
                {
                    score++;
                    fruits[row, col] = "empty";
                }
                else if (fruit == "dynamite")
                {
                    isOver = true;
                    row += step;
                    break;
                }
            }
            return RedirectToAction("Index");
        }
    }
}