using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint2.Task6.V14.Lib;

namespace Tyuiu.EmelianovaKP.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidCondition1()
        {
            Assert.AreEqual("вторник", ds.FindDayName(31, 7));
        }

        [TestMethod]
        public void ValidCondition2()
        {
            Assert.AreEqual("среда", ds.FindDayName(12, 6));
        }

        [TestMethod]
        public void ValidCondition3()
        {
            Assert.AreEqual("понедельник", ds.FindDayName(59, 6));
        }

        [TestMethod]
        public void ValidCondition4()
        {
            Assert.AreEqual("пятница", ds.FindDayName(22, 5));
        }

        [TestMethod]
        public void ValidCondition5()
        {
            Assert.AreEqual("воскресенье", ds.FindDayName(94, 5));
        }

        [TestMethod]
        public void ValidCondition6()
        {
            Assert.AreEqual("четверг", ds.FindDayName(1, 4));
        }

        [TestMethod]
        public void ValidCondition7()
        {
            Assert.AreEqual("воскресенье", ds.FindDayName(365, 7));
        }

        [TestMethod]
        public void ValidCondition8()
        {
            Assert.AreEqual("Некорректные входные данные!", ds.FindDayName(400, 5));
        }

        [TestMethod]
        public void ValidCondition9()
        {
            Assert.AreEqual("Некорректные входные данные!", ds.FindDayName(312, 8));
        }
    }
}
