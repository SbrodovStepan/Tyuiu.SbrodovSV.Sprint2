using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SbrodovSV.Sprint2.Task1.V5.Lib;

namespace Tyuiu.SbrodovSV.Sprint2.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int a = 154, b = 163, c = 134, d = 137;
            bool[] res = new bool[6];
            res = dataService.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[] { true, false, false, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
