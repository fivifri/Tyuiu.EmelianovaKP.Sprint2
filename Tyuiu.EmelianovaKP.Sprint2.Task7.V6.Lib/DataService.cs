using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.EmelianovaKP.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((x * x + y * y <= 4) && (x * x + y * y >= 1) && (y >= 0))
            {
                return true;
            }

            return false;
        }
    }
}
