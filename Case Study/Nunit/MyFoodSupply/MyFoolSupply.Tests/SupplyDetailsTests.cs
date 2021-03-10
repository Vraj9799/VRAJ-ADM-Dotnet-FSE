using MyFoodSupply;
using NUnit.Framework;
using System;

namespace MyFoolSupply.Tests
{
    [TestFixture]
    public class SupplyDetailsTests
    {
        private Program _obj;
        private FoodDetail _foodDetail;
        [OneTimeSetUp]
        public void Initialize()
        {
            _obj = new Program();
            _foodDetail = _obj.CreateFoodDetail("Maggi", 2, new DateTime(2022, 12, 31), 30);
        }

        [Test]
        [TestCase(3, "10-04-2021", "Vraj Shah", 20)]
        public void CreateSupplyDetail_ValidInputs_ExpectedObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var result = _obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, _foodDetail);
            Assert.IsInstanceOf<SupplyDetail>(result);
            Assert.AreEqual(foodItemCount, result.Count);
            Assert.AreEqual(requestDate, result.RequestDate);
            Assert.AreEqual(sellerName, result.SellerName);
            Assert.AreEqual(packingCharge, result.TotalCost - (_foodDetail.Price * foodItemCount));
        }

        [Test]
        [TestCase(0, "01-25-2021", "Vraj Shah", 20)]
        [TestCase(-5, "10-04-2021", "Vraj Shah", 20)]
        public void CreateSupplyDetail_CountLessThanZero_ExpectedException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var result = Assert.Throws<Exception>(() => _obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, _foodDetail));
            Assert.AreEqual("Incorrect food item count. Please check", result.Message);
        }

        [Test]
        [TestCase(10, "10-04-2018", "Vraj Shah", 20)]
        public void CreateSupplyDetail_RequestDateLessThanCurrent_ExpectedException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var result = Assert.Throws<Exception>(() => _obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, _foodDetail));
            Assert.AreEqual("Incorrect food request date. Please provide valid value", result.Message);
        }
        [Test]
        [TestCase(10, "10-04-2021", "Vraj Shah", 20)]
        public void CreateSupplyDetails_FoodItemNull_ExpectedNull(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var result = _obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, null);
            Assert.IsNull(result);
        }
    }
}
