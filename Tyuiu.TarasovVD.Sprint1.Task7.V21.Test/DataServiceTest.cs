using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint1.Task7.V21.Lib;

namespace Tyuiu.TarasovVD.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            double wait = -2.314;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
            
        }
    }
}
