using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint2.Task1.V6.Lib;

namespace Tyuiu.GofmanDV.Sprint2.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetLogicOperationsTest()
        {
            DataService ds = new DataService();
            bool[] wait = new bool[6] { false, false, true, false, true, false };
            int a = 915, b = 169, c = 174, d = 133;
            CollectionAssert.AreEqual(wait, ds.GetLogicOperations(a, b, c, d));
        }
    }
}
