using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Fundamentals.Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Fundamentals.Math();
        }

        [Test]
        [Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //Act
            var result = _math.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        //Writing robust unit tests: Think of method implementation as black box. Don't rely on method implementation.
        //Use TearDown: attribute for Integration tests such as when creating dummy data in database.
        //Trustworthy Tests: If tests are passing, perform a negative test and comment out a line or change a value in the method under test. If test does not fail, then most likely there is a problem with your tests.
        //OR Test Driven development, so you know that tests are correct.
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var result = _math.Max(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
