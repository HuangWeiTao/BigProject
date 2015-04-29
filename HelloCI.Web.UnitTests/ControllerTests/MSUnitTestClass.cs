using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloCI.Web.UnitTests.ControllerTests
{
    [TestClass]
    public class MSUnitTestClass
    {
        [TestMethod]
        public void TestFail()
        {
            Assert.Fail("fail forever.");
        }
    }
}
