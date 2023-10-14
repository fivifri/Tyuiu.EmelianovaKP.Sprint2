using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.EmelianovaKP.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        private bool ThirtyDays(int month)
        {
            return (new[] { 4, 6, 9, 11 }).Contains(month);
        }

        private bool ThirtyOneDays(int month)
        {
            return (new[] { 1, 3, 5, 7, 8, 10, 12 }).Contains(month);
        }

        private string NumberToString(int number)
        {
            return number < 10 ? "0" + number : "" + number;
        }

        private string YearToString(int year)
        {
            string answer = "" + year;

            while (answer.Length < 4) 
            {
                answer = "0" + answer;
            }

            return answer;
        }

        private bool ValidDate(int day, int month, int year) 
        {
            if (year < 0 || year > 9999 || month <= 0 || day <= 0)
            {
                return false;
            }

            if ((year == 0 && month == 1 && day == 1) || (month == 2 && (day > 29)))
            {
                return false;
            }

            if ((ThirtyDays(month) && day > 30) || (ThirtyOneDays(month) && day > 31))
            {
                return false;
            }

            return true;
        }

        private bool LeapYear(int year)
        {
            return (year % 4) == 0;
        }

        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (!ValidDate(n, m, g))
            {
                return "Дата некорректна!";
            }

            if (!LeapYear(g))
            {
                return "Год невисокосный!";
            }

            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1:
                            return "31.12." + YearToString(g - 1);

                        case 3:
                            return "29.02." + YearToString(g);

                        default:
                            if (ThirtyDays(m - 1))
                            {
                                return "30." + NumberToString(m - 1) + "." + YearToString(g);
                            }

                            return "31." + NumberToString(m - 1) + '.' + YearToString(g);

                    }

                default:
                    return NumberToString(n - 1) + "." + NumberToString(m) + "." + YearToString(g);
            }
        }
    }
}
