using System;
using System.ComponentModel.DataAnnotations;

namespace Первая_задача1
{
    internal class Program
    {
        public static void ReadDouble(out double x, string numberName)
        {
            bool isCorrect = false;
            Console.Write("Введите " + numberName + ": ");
            do
            {
                string input = Console.ReadLine();
                if (Double.TryParse(input, out x))
                {
                    x = Convert.ToDouble(input);
                    isCorrect = true;
                }
                else
                {
                    Console.Clear();
                    Console.Write("Повторите ввод числа " + numberName + ": ");
                }
            }
            while (!isCorrect);
            Console.Clear();
        }

        public static void Task1(ref double n, ref double m, ref double x)
        {
            string menu;
            do
            {
                Console.Clear();
                double xDouble;
                double calcResult = n + 1 + m; //выполнил без инкремента, потому что при каждом проходе в функции из-за этого выражения происходит n += 1, что не должно менять её
                bool isGreater = m - 1 > n;
                Console.WriteLine("n = " + n + "; m = " + m + "; x = " + x + ".");
                Console.WriteLine("Задача 1:");
                Console.WriteLine("1) n+++m = " + calcResult);
                Console.WriteLine("2) m-->n " + isGreater);
                isGreater = n - 1 > m;
                Console.WriteLine("3) n-->m " + isGreater);
                xDouble = Math.Sin(x) + Math.Pow(x, 3) + 1 / (Math.Pow(x, 2) + 1);
                Console.WriteLine("4) sin(x) + x*x*x + 1/(x*x + 1) = " + Math.Round(xDouble, 2));
                Console.WriteLine("Введите n, m или x для изменения введённых значений.");
                Console.WriteLine("Для возврата к меню введите return или 0");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "n":
                        {
                            ReadDouble(out n, "n");
                        }
                        break;
                    case "m":
                        {
                            ReadDouble(out m, "m");
                        }
                        break;
                    case "x":
                        {
                            ReadDouble(out x, "x");
                        }
                        break;
                }
            }
            while (menu != "return" && menu != "0");
        }
        
        public static void Task2(ref double x, ref double y)
        {
            string menu;
            bool factCheck;
            do
            {
                Console.Clear();
                Console.WriteLine("x = " + x + "; y = " + y + ".");
                Console.WriteLine("Фигура лежит на осях X и Y с единственной внешней точкой на координатах (5;1)");
                Console.WriteLine("Введите x или y для изменения введённого значения.");
                factCheck = (x <= 5 && x >= 0) && (y >= 0 && y <= 1);
                Console.WriteLine("Входит ли данная точка в заштрихованную область: " + factCheck);
                Console.WriteLine("Для возврата к меню введите return или 0");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "x":
                        {
                            ReadDouble(out x, "x");
                        }
                        break;
                    case "y":
                        {
                            ReadDouble(out y, "y");
                        }
                        break;
                }
            }
            while (menu != "return" && menu != "0");
        }
       
        public static void Task3()
        {
            string menu;
            do
            {
                double resultDouble;
                float resultFloat;
                Console.Clear();
                Console.WriteLine("a = 1000 b = 0.0001.");
                Console.WriteLine("Формула: ((a + b)(a + b) - (a*a +2ab))/b*b");
                double aDouble = 1000, bDouble = 0.0001;
                float aFloat = 1000, bFloat = 0.0001f;
                resultDouble = ((aDouble + bDouble) * (aDouble + bDouble) - (Math.Pow(aDouble, 2) + 2 * aDouble * bDouble))/Math.Pow(bDouble, 2);
                Console.WriteLine("Результат в double: " + resultDouble);
                resultFloat = ((aFloat + bFloat) * (aFloat + bFloat) - ((float)Math.Pow(aFloat, 2) + 2 * aFloat * bFloat)) / (float)Math.Pow(bFloat, 2);
                Console.WriteLine("Результат в float: " + resultFloat);
                Console.WriteLine("Результат ручками: 1");
                Console.WriteLine("Для возврата к меню введите return или 0");
                menu = Console.ReadLine();
            }
            while (menu != "return" && menu != "0");
        }
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            double n = 0, m = 0, x2 = 0, y2 = 0, x = 0;
            string menu;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите 1 для отображения информации по заданию 1.");
                Console.WriteLine("Введите 2 для отображения информации по заданию 2.");
                Console.WriteLine("Введите 3 для отображения информации по заданию 3.");
                Console.WriteLine("Введите 0 для выхода из программы.");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        {
                             Task1(ref n,ref m,ref x);
                        }
                        break;
                    case "2":
                        {
                            Task2(ref x2, ref y2);
                        }
                        break;
                    case "3":
                        {
                            Task3();
                        }
                        break;
                    case "0":
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }
             while (menu!="0");

        }
    }
}