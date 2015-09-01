using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello_World.Controllers;

namespace Hello_World.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new UnitTest1();
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }
    }
}
