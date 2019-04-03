using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestJenkins;
using System.Diagnostics;

namespace MSTestJenkinsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Test t = new Test();
            var res = t.m1("Marish");
            Trace.WriteLine(res);
            Assert.IsNotNull(t);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Test t = new Test();
            var res = t.m1("Marish");
            Trace.WriteLine(res);
            Assert.IsNull(t);
        }

    }
}
