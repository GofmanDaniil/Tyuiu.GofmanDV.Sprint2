using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GofmanDV.Sprint2.Task0.V16.Lib;
namespace Tyuiu.GofmanDV.Sprint2.Task0.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] res = new bool[6];

            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Гофман Д. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: 2.0 Операции сравнения                                            *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Гофман Даниил Викторович | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций ");
            Console.WriteLine("* не должна нарушаться) и арифметических выражений, которая вернет логическую последовательность(массив): ((True, False, True, False, True, False), при x = 1025, y = 275");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X = 1025 , y  = 275");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            res = ds.GetCompareOperations(1025, 275);
            foreach (bool b in res)
            {
                Console.Write(b + " ");
            }


            Console.ReadKey();
        }
    }
}
