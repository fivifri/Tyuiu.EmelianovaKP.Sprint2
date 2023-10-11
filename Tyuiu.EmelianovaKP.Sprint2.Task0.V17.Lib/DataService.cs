using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.EmelianovaKP.Sprint2.Task0.V17.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] answer = new bool[6];

            answer[0] = x - 310 == y;
            answer[1] = x - 310 != y;
            answer[2] = x < y;
            answer[3] = x - 500 > y;
            answer[4] = x <= y;
            answer[5] = x - 400 >= y;

            return answer;
        }
    }
}
