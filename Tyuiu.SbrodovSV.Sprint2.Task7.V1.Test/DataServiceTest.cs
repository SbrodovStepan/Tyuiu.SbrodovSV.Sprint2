using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SbrodovSV.Sprint2.Task7.V1.Lib;

namespace Tyuiu.SbrodovSV.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double x = 0, y = 1;
            bool res = dataService.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}
