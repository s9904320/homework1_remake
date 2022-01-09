using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1.Tests
{
    [TestClass()]
    public class StringAverageTests
    {
        [TestMethod()]
        public void AverageStringTest()
        {
            //Arrange
            string[] actual = {
                null,
                "",
                "zero nine five two",
                "four six two three",
                "one two three four five",
                "five four",
                "zero zero zero zero zero",
                "one one eight one"
            };
            string[] trueAnswer = {
            "n/a",
            "n/a",
            "four",
            "three",
            "three",
            "four",
            "zero",
            "two"
            };
            //Act
            string[] answer = new string[actual.Length];
            for (int i = 0; i < actual.Length; i++)
            {
                answer[i] = StringAverage.AverageString(actual[i]);
            }
            //Assert
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(trueAnswer[i], answer[i]);
            }
        }

        [TestMethod]
        public void testNullOrEmpty()
        {
            Assert.AreEqual("n/a", StringAverage.AverageString(null));
            Assert.AreEqual("n/a", StringAverage.AverageString(""));
        }
        [TestMethod]
        public void testZero()
        {
            Assert.AreEqual("zero", StringAverage.AverageString("zero zero zero zero zero"));
        }
        [TestMethod]
        public void testNormal()
        {
            Assert.AreEqual("four", StringAverage.AverageString("zero nine five two"));
            Assert.AreEqual("three", StringAverage.AverageString("one two three four five"));
        }
        [TestMethod]
        public void testFloor()
        {
            Assert.AreEqual("three", StringAverage.AverageString("four six two three")); 
            Assert.AreEqual("four", StringAverage.AverageString("five four"));
            Assert.AreEqual("two", StringAverage.AverageString("one one eight one")); 
        }
    }
}