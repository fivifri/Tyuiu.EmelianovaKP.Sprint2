using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint2.Task7.V6.Lib;

namespace Tyuiu.EmelianovaKP.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidCondition1()
        {
            Assert.AreEqual(true, ds.CheckDotInShadedArea(2, 0));
        }

        [TestMethod]
        public void ValidCondition2()
        {
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-1, 0));
        }

        [TestMethod]
        public void ValidCondition3()
        {
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0, 0));
        }

        [TestMethod]
        public void ValidCondition4()
        {
            Assert.AreEqual(false, ds.CheckDotInShadedArea(2.1, 1));
        }

        [TestMethod]
        public void ValidCondition5()
        {
            Assert.AreEqual(false, ds.CheckDotInShadedArea(-1, -1));
        }

        [TestMethod]
        public void ValidCondition6()
        {
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-1, 1));
        }

        [TestMethod]
        public void ValidCondition7()
        {
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.6, 0.6));
        }

        [TestMethod]
        public void ValidCondition8()
        {
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, -0.1));
        }

        [TestMethod]
        public void ValidCondition9()
        {
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, 2));
        }

        [TestMethod]
        public void ValidCondition10()
        {
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-2, 0));
        }
    }
}
