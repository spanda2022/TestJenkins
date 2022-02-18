using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string Excepted = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw=new StringWriter())
            {
                Console.SetOut(sw);
                TestJenkins.Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Excepted, result);
            }
        }
    }
}
