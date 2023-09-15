using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KolchakovDR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KolchakovDR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "*Danil*";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hello 0.o *Danil*", res);
        }
    }
}
