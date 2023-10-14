using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint1.Task3.V10.Lib;

namespace Tyuiu.TarasovVD.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.NumberToMoney(23.6);
            string expected = string.Format("{0:0.##} руб. {1:00} коп.", Math.Floor(res), (res - Math.Floor(res)) * 100);
            string actual = string.Format("{0:0.##} руб. {1:00} коп.", Math.Floor(23.6), (23.6 - Math.Floor(23.6)) * 100);
            Assert.AreEqual(expected, actual);


        }
    }
}
