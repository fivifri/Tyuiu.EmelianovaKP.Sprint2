using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint2.Task0.V17.Lib;

namespace Tyuiu.EmelianovaKP.Sprint2.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            var ds = new DataService();

            bool[] wait = new bool[6] { true, false, false, false, false, false };
            CollectionAssert.AreEqual(wait, ds.GetCompareOperations(1065, 755));
        }
    }
}
