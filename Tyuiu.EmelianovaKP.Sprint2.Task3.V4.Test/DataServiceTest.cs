using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint2.Task3.V4.Lib;

namespace Tyuiu.EmelianovaKP.Sprint2.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidCondition1()
        {
            Assert.AreEqual(15.467, ds.Calculate(8));
        }

        [TestMethod]
        public void ValidCondition2()
        {
            Assert.AreEqual(0.083, ds.Calculate(0));
        }

        [TestMethod]
        public void ValidCondition3()
        {
            Assert.AreEqual(0.198, ds.Calculate(-2));
        }

        [TestMethod]
        public void ValidCondition4()
        {
            Assert.AreEqual(-219.950, ds.Calculate(-20));
        }

        [TestMethod]
        public void ValidCondition5()
        {
            Assert.AreEqual(0, ds.Calculate(-8));
        }
    }
}
