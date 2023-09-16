using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KolchakovDR.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckedSubValid()
        {
            Assert.AreEqual(5, DataService.Sub(10, 5));
        }

        public void CheckedMultValid()
        {
            Assert.AreEqual(50, DataService.Mult(10, 5));
        }

        public void CheckedDivValid()
        {
            Assert.AreEqual(2, DataService.Div(10, 5));
        }
    }
}
