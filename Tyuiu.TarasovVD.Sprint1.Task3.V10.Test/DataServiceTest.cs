﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual("23 руб. 60 коп. ", res);
        }
    }
}
