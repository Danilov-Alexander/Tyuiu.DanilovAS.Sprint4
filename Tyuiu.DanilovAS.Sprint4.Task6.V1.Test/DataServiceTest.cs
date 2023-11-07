using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint4.Task6.V1.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            //[Яблоко, Банан, Вишня, Драгонфрут, Бузина,  *");
            //Console.WriteLine("* Инжир, Виноград]
            var task = new string[] {"Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            int res = ds.Calculate(task);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
