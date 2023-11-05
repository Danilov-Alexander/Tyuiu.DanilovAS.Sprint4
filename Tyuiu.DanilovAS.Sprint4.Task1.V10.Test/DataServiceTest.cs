using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint4.Task1.V10.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5 };
            int wait = 15;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);

        }
    }
}
