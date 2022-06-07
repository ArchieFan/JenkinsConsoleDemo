using JenkinsConsoleDemo;

namespace JenkinsConsoleDemo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", JenkinsConsoleDemo.createMsg());
        }
    }
}