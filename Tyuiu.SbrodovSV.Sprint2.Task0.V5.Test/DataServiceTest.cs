using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SbrodovSV.Sprint2.Task0.V5.Lib;

namespace Tyuiu.SbrodovSV.Sprint2.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int x = 105, y = 223;
            bool[] res = new bool[6];
            res = dataService.GetCompareOperations(x, y);
            bool[] wait = new bool[] { false, true, true, true, false, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
