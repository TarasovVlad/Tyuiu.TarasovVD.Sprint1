using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint1.Task5.V3.Lib;

namespace Tyuiu.TarasovVD.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int number = 130985;
            int expected = 9;

            int res = ds.Calculate(number);

            Assert.AreEqual(expected, res);
        }
    }
}
