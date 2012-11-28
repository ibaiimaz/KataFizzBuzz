using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using KataFizzBuzz;
using NUnit.Framework;

namespace KataFizzBuzzTests
{
    // ReSharper disable InconsistentNaming
    // ReSharper disable PossibleNullReferenceException

    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            fizzBuzz = new FizzBuzz();
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void Set_NormalNumber_ReturnsNumber(int number, string expected)
        {
            var resp = fizzBuzz.GetNumberConversion(number);

            Assert.AreEqual(expected, resp);
        }

        [Test]
        public void Set_Three_ReturnsFizz()
        {
            var resp = fizzBuzz.GetNumberConversion(3);

            Assert.AreEqual("Fizz", resp);
        }

        [Test]
        public void Set_Five_ReturnsBuzz()
        {
            var resp = fizzBuzz.GetNumberConversion(5);

            Assert.AreEqual("Buzz",resp);
        }

        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(12, "Fizz")]
        public void Set_NumberDivisibleByThree_ReturnsFizz(int number, string expected)
        {
            var resp = fizzBuzz.GetNumberConversion(number);

            Assert.AreEqual(expected,resp);
        }

        [TestCase(10, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(25, "Buzz")]
        public void Set_NumberDivisibleByFive_ReturnsBuzz(int number, string expected)
        {
            var resp = fizzBuzz.GetNumberConversion(number);

            Assert.AreEqual(expected, resp);
        }

        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(45, "FizzBuzz")]
        public void Set_NumberDivisibleByThreeAndFive_ReturnsFizzBuzz(int number, string expected)
        {
            var resp = fizzBuzz.GetNumberConversion(number);

            Assert.AreEqual(expected, resp);
        }

        [TestCase(13, "Fizz")]
        [TestCase(23, "Fizz")]
        [TestCase(31, "Fizz")]
        public void Set_NumberContainingThree_ReturnsFizz(int number, string expected)
        {
            var resp = fizzBuzz.GetNumberConversion(number);

            Assert.AreEqual(expected, resp);
        }

        [TestCase(52, "Buzz")]
        [TestCase(56, "Buzz")]
        [TestCase(58, "Buzz")]
        public void Set_NumberContainingFive_ReturnsBuzz(int number, string expected)
        {
            var resp = fizzBuzz.GetNumberConversion(number);

            Assert.AreEqual(expected, resp);
        }

        [TestCase(53, "FizzBuzz")]
        public void Set_NumberContainingThreeAndFive_ReturnsFizzBuzz(int number, string expected)
        {
            var resp = fizzBuzz.GetNumberConversion(number);

            Assert.AreEqual(expected, resp);
        }
    }

    // ReSharper restore InconsistentNaming
    // ReSharper restore PossibleNullReferenceException
}