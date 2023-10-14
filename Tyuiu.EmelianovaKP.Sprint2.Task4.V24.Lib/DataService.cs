using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.EmelianovaKP.Sprint2.Task4.V24.Lib
{
    public class DataService : ISprint2Task4V24
    {
        private double Expression1(double x, double y)
        {
            return Math.Round(x * Math.Pow((y + 1) / (x + 2), x), 3);
        }

        private double Expression2(double x, double y)
        {
            return Math.Round((y * y + 9 + Math.Pow(Math.Cos(x), 2)) / 
                (x * x + 12 - Math.Pow(Math.Sin(y), 2)), 3);
        }

        public double Calculate(double x, double y)
        {
            return x + 2 > y + 24 ? Expression1(x, y) : Expression2(x, y);
        }
    }
}
