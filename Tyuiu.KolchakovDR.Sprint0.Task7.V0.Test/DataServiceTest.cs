using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint0.Task7.V0.Lib;
namespace Tyuiu.KolchakovDR.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekAddArrayValid()
        {
            int[] num1 = new int[] { 1, 1, 1, 1, 1 };
            int[] num2 = new int[] { 1, 1, 1, 1, 1 };
            int[] num3 = new int[] { 2, 2, 2, 2, 2 };

            int[] res = DataService.AddArray(num1, num2);
            CollectionAssert.AreEqual(num3, res);
        }
    }
}
