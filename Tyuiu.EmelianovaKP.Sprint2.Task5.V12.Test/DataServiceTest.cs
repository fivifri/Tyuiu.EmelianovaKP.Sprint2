using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint2.Task5.V12.Lib;

namespace Tyuiu.EmelianovaKP.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidCondition1()
        {
            Assert.AreEqual("31.12.0999", ds.FindDateOfPreviousDay(1000, 1, 1));
        }

        [TestMethod]
        public void ValidCondition2()
        {
            Assert.AreEqual("01.01.1984", ds.FindDateOfPreviousDay(1984, 1, 2));
        }

        [TestMethod]
        public void ValidCondition3()
        {
            Assert.AreEqual("29.02.2004", ds.FindDateOfPreviousDay(2004, 3, 1));
        }

        [TestMethod]
        public void ValidCondition4()
        {
            Assert.AreEqual("30.11.2008", ds.FindDateOfPreviousDay(2008, 12, 1));
        }

        [TestMethod]
        public void ValidCondition5()
        {
            Assert.AreEqual("Год невисокосный!", ds.FindDateOfPreviousDay(1987, 10, 25));
        }

        [TestMethod]
        public void ValidCondition6()
        {
            Assert.AreEqual("Дата некорректна!", ds.FindDateOfPreviousDay(-654, 10, 24));
        }

        [TestMethod]
        public void ValidCondition7()
        {
            Assert.AreEqual("Дата некорректна!", ds.FindDateOfPreviousDay(2012, 9, 0));
        }

        [TestMethod]
        public void ValidCondition8()
        {
            Assert.AreEqual("Дата некорректна!", ds.FindDateOfPreviousDay(4, -5, 6));
        }

        [TestMethod]
        public void ValidCondition9()
        {
            Assert.AreEqual("Дата некорректна!", ds.FindDateOfPreviousDay(2016, 11, 31));
        }

        [TestMethod]
        public void ValidCondition10()
        {
            Assert.AreEqual("Дата некорректна!", ds.FindDateOfPreviousDay(2020, 10, 32));
        }

        [TestMethod]
        public void ValidCondition11()
        {
            Assert.AreEqual("31.03.0008", ds.FindDateOfPreviousDay(8, 4, 1));
        }
    }
}
