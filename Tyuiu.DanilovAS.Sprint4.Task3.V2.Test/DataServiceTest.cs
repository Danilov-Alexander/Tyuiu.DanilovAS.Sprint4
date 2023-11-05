using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint4.Task3.V2.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] 
            
                {{4,3,2,8,7 },
                {4,6,5,5,7},
                {3,8,8,3,5},
                {5,7,5,4,4},
                {8,8,3,7,6} };

            int wait = 7;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);

        }
    }
}
