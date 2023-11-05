using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint4.Task0.V16.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] arrayTest = new int[] { 2, 4, 3, 7, 5, 1 };
            int wait = 30;
            int res = ds.GetMultEvenArrEl(arrayTest);
            Assert.AreEqual(wait,res);

        }
    }
}
