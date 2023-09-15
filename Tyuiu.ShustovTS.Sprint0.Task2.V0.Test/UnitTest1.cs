using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Tyuiu.ShustovTS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Тим";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Тим", res);
        }
    }
}
