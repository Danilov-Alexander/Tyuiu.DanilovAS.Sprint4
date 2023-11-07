using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint4.Task7.V14.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            //"458712659137"
            int rows = 3;
            int columns = 4;
            int[,] array = new int[rows, columns];
            string str = "458712659137";
            int res = ds.Calculate(rows, columns, str);
            int wait = 8;
            Assert.AreEqual(wait,res);

        }
    }
}
