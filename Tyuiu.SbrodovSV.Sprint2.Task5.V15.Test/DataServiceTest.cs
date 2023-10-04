using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SbrodovSV.Sprint2.Task5.V15.Lib;

namespace Tyuiu.SbrodovSV.Sprint2.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual("Понедельник", dataService.FindDayName(1));
            Assert.AreEqual("Вторник", dataService.FindDayName(2));
            Assert.AreEqual("Среда", dataService.FindDayName(3));
            Assert.AreEqual("Четверг", dataService.FindDayName(4));
            Assert.AreEqual("Пятница", dataService.FindDayName(5));
            Assert.AreEqual("Суббота", dataService.FindDayName(6));
            Assert.AreEqual("Воскресенье", dataService.FindDayName(7));
        }
    }
}
