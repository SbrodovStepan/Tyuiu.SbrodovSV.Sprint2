using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SbrodovSV.Sprint2.Task0.V5.Lib;

namespace Tyuiu.SbrodovSV.Sprint2.Task0.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            int x = 105, y = 223;
            bool[] res = new bool[6];
            res = dataService.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнил: Сбродов С. В. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Сбродов Степан Владимирович | АСОиУб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)*");
            Console.WriteLine("* и арифметических выражений,                                             *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
            Console.WriteLine("* ((False, True, True, True, False, True), при x = 105, y = 223           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
