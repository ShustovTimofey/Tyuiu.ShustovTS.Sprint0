using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShustovTS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShustovTS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Тимофей";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Тимофей", res);

        }
    }
}
