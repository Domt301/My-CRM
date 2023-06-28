using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPlugins;
using System;

namespace MyPluginsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanAddTwoNumbers()
        {
            // Arrange
            var x = 1;
            var y = 2;
            var expected = 3;
            AddNumbersClass addnumbersClass = new AddNumbersClass();


            // Act
            var actual = addnumbersClass.AddTwoNumbers(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanSubtractTwoNumbers()
        {
            // Arrange
            var x = 1;
            var y = 2;
            var expected = -1;
            SubtractNumbersClass subtractnumbersClass = new SubtractNumbersClass();

            var actual = subtractnumbersClass.SubtractTwoNumbers(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
