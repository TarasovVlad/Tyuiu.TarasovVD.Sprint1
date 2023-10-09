using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TarasovVD.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public double NumberToMoney(double number)
        {
            double rubles = Math.Floor(number);
            double kopecks = Math.Round((number - rubles) * 100);
            double moneyValue = rubles + kopecks / 100.0;
            return moneyValue;
        }
    }
}
