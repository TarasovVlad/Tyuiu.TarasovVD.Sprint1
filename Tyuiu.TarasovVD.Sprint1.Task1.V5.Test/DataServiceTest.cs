﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint1.Task1.V5.Lib;
namespace Tyuiu.TarasovVD.Sprint1.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(7, res);
        }
    }
}
