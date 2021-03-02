using NUnit.Framework;
using System;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private SimpleCalculator _simpleCalculator;
        private double _result;
        [SetUp]
        public void Initialize()
        {
            _simpleCalculator = new SimpleCalculator();
            _result = 0;
        }
        [Test]
        [TestCase(10, 20, 30)]
        [TestCase(1, 2, 3)]
        public void Addition_ValidInputs_ExpectedResult(double a, double b, double expected)
        {
            _result = _simpleCalculator.Addidtion(a, b);
            Assert.AreEqual(expected, _result);
        }
        [Test]
        [TestCase(10, 20, -10)]
        [TestCase(10, 2, 8)]
        public void Subtraction_ValidInputs_ExpectedResult(double a, double b, double expected)
        {
            _result = _simpleCalculator.Subtraction(a, b);
            Assert.AreEqual(expected, _result);
        }
        [Test]
        [TestCase(10, 20, 200)]
        [TestCase(10, 0, 0)]
        public void Multiplication_ValidInputs_ExpectedResult(double a, double b, double expected)
        {
            _result = _simpleCalculator.Multiplication(a, b);
            Assert.AreEqual(expected, _result);
        }
        [Test]
        [TestCase(10, 2, 5)]
        public void Division_ValidInputs_ExpectedResult(double a, double b, double expected)
        {
            _result = _simpleCalculator.Division(a, b);
            Assert.AreEqual(expected, _result);
        }
        [Test]
        [TestCase(10, 0)]

        public void Division_InValidInputs_ExpectedException(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => _simpleCalculator.Division(a, b));
        }
        [TearDown]
        public void CleanUp()
        {
            _simpleCalculator.AllClear();
            _result = _simpleCalculator.GetResult;
        }
    }
}
