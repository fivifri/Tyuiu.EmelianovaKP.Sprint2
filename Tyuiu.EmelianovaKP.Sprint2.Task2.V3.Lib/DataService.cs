using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.EmelianovaKP.Sprint2.Task2.V3.Lib
{
    public class DataService : ISprint2Task2V3
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 && x <= 5 && y >= 3 && y <= 5) || (x == 3 && y == 11))
            {
                return true;
            }

            if ((x == 4 && y >= 9 && y <= 13) || (x == 7 && y == 13) || (x == 6 && y == 5))
            {
                return true;
            }

            if ((y == 9 && x >= 5 && x <= 6) || (x == 13 && y >= 6 && y <= 13 && y != 9 && y != 10))
            {
                return true;
            }

            if ((y >= 3 && y <= 8 && x >= 9 && x <= 10) || (y == 3 && x >= 11 && x <= 12))
            {
                return true;
            }
            
            if ((y >= 6 && y <= 13 && x >= 11 && x <= 12) || (y >= 5 && y <= 12 && x >= 7 && x <= 8))
            {
                return true;
            }

            return false;
        }
    }
}
