using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI.Models;

namespace HelloWorldAPI.Tests
{
    [TestClass]
    public class HelloTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            HelloWorld testInfo = new HelloWorld();
            string expected = "Hello World!";

            Assert.AreEqual(expected, testInfo.Welcome, false, "The response is not Hello World!");
        }
    }
}
