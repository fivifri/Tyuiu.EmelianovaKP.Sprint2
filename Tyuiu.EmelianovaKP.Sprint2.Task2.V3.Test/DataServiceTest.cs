using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint2.Task2.V3.Lib;

namespace Tyuiu.EmelianovaKP.Sprint2.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.AreEqual(true, ds.CheckDotInShadedArea(8, 8));
        }
    }
}
