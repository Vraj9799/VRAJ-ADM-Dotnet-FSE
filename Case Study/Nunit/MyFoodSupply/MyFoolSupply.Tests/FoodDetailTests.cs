using MyFoodSupply;
using NUnit.Framework;
using System;

namespace MyFoolSupply.Tests
{
    [TestFixture]
    public class FoodDetailTests
    {
        private Program _obj;
        [OneTimeSetUp]
        public void Initialize()
        {
            _obj = new Program();
        }
        [Test]
        [TestCase("Maggi", 2, "04-04-2022", 30)]
        public void CreateFoodDetail_ValidInputs_ExpectedObject(string name, int dishType, DateTime expiryDate, double price)
        {
            var result = _obj.CreateFoodDetail(name, dishType, expiryDate, price);
            Assert.IsInstanceOf<FoodDetail>(result);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(dishType, (int)result.DishType);
            Assert.AreEqual(expiryDate, result.ExpiryDate);
            Assert.AreEqual(price, result.Price);
        }

        [Test]
        [TestCase(null, 2, "04-04-2022", 30)]
        [TestCase("", 2, "04-04-2022", 30)]
        public void CreateFoodDetail_EmptyName_ExpectedException(string name, int dishType, DateTime expiryDate, double price)
        {
            var result = Assert.Throws<Exception>(() => _obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Dish name cannot be empty. Please provide valid value", result.Message);
        }
        [Test]
        [TestCase("Maggi", 2, "04-04-2022", -30)]
        public void CreateFoodDetail_PriceLessThanZero_ExpectedException(string name, int dishType, DateTime expiryDate, double price)
        {
            var result = Assert.Throws<Exception>(() => _obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect value for dish price. Please provide valid value", result.Message);
        }
        [Test]
        [TestCase("Maggi", 2, "04-04-2018", 30)]
        public void CreateFoodDetail_ExpiryDateLessThanCurrent_ExpectedException(string name, int dishType, DateTime expiryDate, double price)
        {
            var result = Assert.Throws<Exception>(() => _obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", result.Message);
        }
    }
}
