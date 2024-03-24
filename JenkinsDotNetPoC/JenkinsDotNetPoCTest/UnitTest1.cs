using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsDotNetPoC;

namespace JenkinsDotNetPoCTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMain()
        {
            // Arrange
            string expected = "Hello, World!";

            // Act
            string actual = Program.DoWork();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
