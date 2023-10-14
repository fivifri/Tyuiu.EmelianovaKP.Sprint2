using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint2.Task4.V24.Lib;

namespace Tyuiu.EmelianovaKP.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidCondition1()
        {
            Assert.AreEqual(22.265, ds.Calculate(10, - 14));
        }

        [TestMethod]
        public void ValidCondition2()
        {
            Assert.AreEqual(1.092, ds.Calculate(1, 2));
        }
    }
}
