using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.EmelianovaKP.Sprint2.Task1.V16.Lib
{
    public class DataService : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] answer = new bool[6];

            answer[0] = (a != b) | (c == d);
            answer[1] = (a < b) & (c > d);
            answer[2] = (a <= b) || (c >= d);
            answer[3] = (a == b) && (c != d);
            answer[4] = !(a > b);
            answer[5] = (a == b) ^ (c <= d);

            return answer;
        }
    }
}
