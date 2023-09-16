using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint0.Task6.V0.Lib;
namespace Tyuiu.KolchakovDR.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAddArrayValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5, 6 };
            var res = DataService.AddArray(num);
            Assert.AreEqual(21, res);
        }
        public void CheckSubArrayValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5, 6 };
            var res = DataService.SubArray(num);
            Assert.AreEqual(-21, res);
        }
        public void CheckMultArrayValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5, 6 };
            var res = DataService.MultArray(num);
            Assert.AreEqual(720, res);
        }
        public void CheckDivArrayValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5, 6 };
            var res = DataService.MultArray(num);
            Assert.AreEqual(1, res);
        }
    }
}
