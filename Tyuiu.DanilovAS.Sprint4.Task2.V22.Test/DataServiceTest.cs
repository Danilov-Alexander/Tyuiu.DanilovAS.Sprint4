using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint4.Task2.V22.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 1, 3, 5, 7, 9, 2, 4, 6, 5 };
            int wait = 4725;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
