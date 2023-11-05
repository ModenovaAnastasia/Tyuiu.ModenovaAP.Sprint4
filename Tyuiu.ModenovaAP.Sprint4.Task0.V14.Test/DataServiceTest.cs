using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint4.Task0.V14.Lib;

namespace Tyuiu.ModenovaAP.Sprint4.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int res = ds.GetSumOddArrEl(array);
            Assert.AreEqual(30, res);
        }
    }
}
