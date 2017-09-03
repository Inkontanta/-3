using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = 0, Y = 0;
            bool ok = false, j = false;
            while (!j)
            {
                while (!ok)    //проверка ввода переменной Х
                {
                    try
                    {
                        Console.WriteLine("Введите координаты Х:");
                        X = Convert.ToDouble(Console.ReadLine());
                        ok = true;
                    }
                    catch
                    {
                        Console.WriteLine("Число введено неверно, повторите ввод");
                        ok = false;
                    }
                }
                ok = false;

                while (!ok)               //проверка ввода переменной Y
                {
                    try
                    {
                        Console.WriteLine("Введите координаты Y:");
                        Y = Convert.ToDouble(Console.ReadLine());
                        ok = true;
                    }
                    catch
                    {
                        Console.WriteLine("Число введено неверно, повторите ввод");
                        ok = false;
                    }
                }
                ok = false;  //Проверка условия принадлежности области

                if (((X >= -1) & (X <= 0) & (Y >= 0) & (Y <= 1)) ||
                   ((X >= -1.5) & (X <= -1) & (Y >= 0) & (Y <= 1)) ||
                   ((Y <= 0) & (Y >= -1) & (Y <= 2 * X + 3) & (Y >= 1 / 3 * X - 1 / 3)))
                    Console.WriteLine("Точка принадлежит данной области"); //Вывод
                else
                    Console.WriteLine("Точка не принадлежит данной области"); //Вывод
                Console.ReadLine();
            }
        }
    }
}
