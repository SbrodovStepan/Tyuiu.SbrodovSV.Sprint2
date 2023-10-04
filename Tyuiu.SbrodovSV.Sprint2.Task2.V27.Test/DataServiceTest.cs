using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SbrodovSV.Sprint2.Task2.V27.Lib;

namespace Tyuiu.SbrodovSV.Sprint2.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int x = 13, y = 12;
            bool res = dataService.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}
