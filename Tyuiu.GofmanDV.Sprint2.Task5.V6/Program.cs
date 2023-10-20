using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GofmanDV.Sprint2.Task5.V6.Lib;

namespace Tyuiu.GofmanDV.Sprint2.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Гофман Д. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант 6                                                               *");
            Console.WriteLine("* Выполнил: Гофман Даниил Викторович | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер масти m:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер достоинства k:");
            int k = Convert.ToInt32(Console.ReadLine());

            string res;
            if (m > 4 || m < 0 || k < 6 || k > 14)
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Ваша карта: " + ds.FindCardNameAndValue(m, k);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
