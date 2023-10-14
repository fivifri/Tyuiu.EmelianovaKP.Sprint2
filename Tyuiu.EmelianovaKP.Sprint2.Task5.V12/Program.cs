using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint2.Task5.V12.Lib;

namespace Tyuiu.EmelianovaKP.Sprint2.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Емельянова К. П. | ПКТб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Емельянова К. П. | ПКТб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет       *");
            Console.WriteLine("* требуемое значение и возвращает результат. Условие: Дата некоторого дня *");
            Console.WriteLine("* характеризуется тремя натуральными числами: g (год), m (порядковый      *");
            Console.WriteLine("* номер месяца) и n (число). По заданным g, n и m определить дату         *");
            Console.WriteLine("* предыдущего дня. Заданный год является високосным.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.Write("Year = ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Month = ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("day = ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.FindDateOfPreviousDay(year, month, day));

            Console.ReadKey();
        }
    }
}
