using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.EmelianovaKP.Sprint2.Task3.V4.Lib
{
    public class DataService : ISprint2Task3V4
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return Math.Round(x + Math.Pow((x + 1) / (x - 1), x), 3);
            }

            if (x == 0)
            {
                return Math.Round((x * x + Math.Cos(x * x)) / (x * x - Math.Sin(x * x) + 12), 3);
            }

            if (x < -8)
            {
                return Math.Round(x + 10 * x - 1 / x, 3);
            }

            if (x > -8 && x < 0)
            {
                return Math.Round(Math.Pow(x - 1 / Math.Pow(x, 2), x), 3);
            }

            return 0;
        }
    }
}
