using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppForUnitTesting
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestPersonNameProperty()
        {
            // Arrange
            Person person = new Person();
            string expectedName = "Liam";

            // Act
            person.Name = expectedName;
            string actualName = person.Name;

            // Assert
            Assert.AreEqual(expectedName, actualName, "The Name property did not return the expected value.");
        }

        [TestMethod]
        public void TestMainMethodWithSingleArgument()
        {
            // Arrange
            string[] args = { "Liam" };
            string expectedOutput = "Liam";
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Program.Main(args);

                // Assert
                var result = sw.ToString().Trim();
                Assert.AreEqual(expectedOutput, result, "The Main method did not output the expected value.");
            }
        }

        [TestMethod]
        public void TestMainMethodWithMultipleArguments()
        {
            // Arrange
            string[] args = { "Liam", "Emma", "Noah" };
            string expectedOutput = "Noah";
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Program.Main(args);

                // Assert
                var result = sw.ToString().Trim();
                Assert.AreEqual(expectedOutput, result, "The Main method did not output the expected value.");
            }
        }

        [TestMethod]
        public void TestMainMethodWithNoArguments()
        {
            // Arrange
            string[] args = { };
            string expectedOutput = "";
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Program.Main(args);

                // Assert
                var result = sw.ToString().Trim();
                Assert.AreEqual(expectedOutput, result, "The Main method did not output the expected value.");
            }
        }
    }
}

