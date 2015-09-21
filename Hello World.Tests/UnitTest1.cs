using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello_World.Controllers;
using System.Web.UI.WebControls;

namespace Hello_World.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new UnitTest1();
            var result = TestMethod1(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }

        private ViewResult TestMethod1(int p)
        {
            throw new NotImplementedException();
        }
    }
}
