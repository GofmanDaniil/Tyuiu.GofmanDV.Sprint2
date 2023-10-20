using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GofmanDV.Sprint2.Task0.V16.Lib
{
    public class DataService : ISprint2Task0V16
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] bolean = new bool[6];
            bolean[0] = x - 750 == y;
            bolean[1] = x - 750 != y;
            bolean[2] = x < y + 1000;
            bolean[3] = x - 1025 > y;
            bolean[4] = x <= y + 800;
            bolean[5] = x >= y + 2000;

            return bolean;
        }
    }
}
