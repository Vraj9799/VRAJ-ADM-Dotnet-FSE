using NUnit.Framework;

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
        [TestCase(2, 5, 7)]
        [TestCase(2, 0, 2)]
        [TestCase(0, 5, 5)]
        [TestCase(0, 0, 0)]
        public void Addition_ValidInputs_ExpectedResult(double a, double b, double expected)
        {
            _result = _simpleCalculator.Addidtion(a, b);
            Assert.AreEqual(expected, _result);
        }
        [TearDown]
        public void CleanUp()
        {
            _simpleCalculator.AllClear();
            _result = _simpleCalculator.GetResult;
        }
    }
}
