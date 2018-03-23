using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace WebApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            "that string".Should().NotBeEmpty().And.HaveLength(11);
        }

        [TestMethod]
        public void Failed()
        {
            "a".Should().BeEmpty();
        }
    }
}
