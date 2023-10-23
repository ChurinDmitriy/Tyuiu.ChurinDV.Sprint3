using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint3.Task6.V10.Lib;

namespace Tyuiu.ChurinDV.Sprint3.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 20;
            int stopVAlue = 32;

            int res = ds.GetSumTheDivisors(startValue, stopVAlue);

            int wait = 396;

            Assert.AreEqual(wait, res);
        }
    }
}
