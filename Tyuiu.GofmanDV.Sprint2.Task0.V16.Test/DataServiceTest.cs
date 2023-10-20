using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint2.Task0.V16.Lib;
namespace Tyuiu.GofmanDV.Sprint2.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            bool[] res = new bool[6];
            bool[] wait = new bool[] { true, false, true, false, true, false };

            res = ds.GetCompareOperations(1025, 275);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
