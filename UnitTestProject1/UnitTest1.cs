using System;
using ClassLibrary3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c = new Class1();

            var result = c.GetName();

            Assert.AreEqual("Martin", result);

        }
    }
}
