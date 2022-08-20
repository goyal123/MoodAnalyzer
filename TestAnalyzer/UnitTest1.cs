using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;

namespace TestAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("I am in Sad Mood", "Sad")]
        [DataRow("I am in Happy Mood", "Happy")]
        [DataRow("I am in any Mood", "unknown")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        [DataRow("", "String is Empty")]
        public void TestMethod1(string msg,string expected)
        {
            //Arrange
            Analyze obj = new Analyze(msg);
            //Assert
            string actual = obj.Analyzemood();
            //Act
            Assert.AreEqual(expected, actual);
        }
    }
}
