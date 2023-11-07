using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint4.Task5.V23.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            int[,] array = new int[3, 3] { {-1,-5,-7 },{-1,-5,-4 },{-1,-6,-4 } };
            int[,] resArray = ds.Calculate(array);
            int[,] waitArray = { {0,0,0 }, {0,0,0}, {0,0,0}};

            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}
