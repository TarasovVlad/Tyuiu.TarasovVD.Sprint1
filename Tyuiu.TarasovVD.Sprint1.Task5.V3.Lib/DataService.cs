using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TarasovVD.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            string numberStr = k.ToString();
            char thirdFromEndChar = numberStr[numberStr.Length - 3];
            return int.Parse(thirdFromEndChar.ToString());
        }
    }
}
