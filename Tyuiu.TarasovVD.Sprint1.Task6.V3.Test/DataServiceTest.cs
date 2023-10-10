using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint1.Task6.V3.Lib;

namespace Tyuiu.TarasovVD.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string value = "Hello World";
            string expected = "od";

            string res = ds.LastLetterWord(value);

            Assert.AreEqual(expected, res);
        }
    }
}
