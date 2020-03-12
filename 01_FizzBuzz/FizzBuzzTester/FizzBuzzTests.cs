using NUnit.Framework;
using System.Collections.Generic;
using FizzBuzz;

namespace FizzBuzzTester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SimpleFizzBuzzTest()
        {
            List<int> numbers = new List<int>() { 15 };
            List<string> expectedResults = new List<string>() { "FizzBuzz" };
            var actualResluts = FizzBuzzer.MillNumbers(numbers);
            Assert.AreEqual(expectedResults[0], actualResluts[0]);
        }

        [Test]
        public void BuzzTest()
        {
            List<int> numbers = new List<int>() { 1, 5, 10 };
            List<string> expectedResults = new List<string>() { "1", "Buzz", "Buzz" };
            var actualResluts = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResluts);
        }

        [Test]
        public void FizzTest()
        {
            List<int> numbers = new List<int>() { 3, 6, 9, 12 };
            List<string> expectedResults = new List<string>() { "Fizz", "Fizz", "Fizz", "Fizz" };
            var actualResluts = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResluts);
        }

        [Test]
        public void MoreRealisticTest()
        {
            List<int> numbers = new List<int>() {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<string> expectedResults = new List<string>() {
                "1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz",
                 "11","Fizz","13","14","FizzBuzz","16","17","Fizz","19","Buzz"};
            var actualResluts = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResluts);
        }
    }
}