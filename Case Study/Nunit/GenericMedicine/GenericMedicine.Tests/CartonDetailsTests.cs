using NUnit.Framework;
using System;

namespace GenericMedicine.Tests
{
    [TestFixture]
    public class CartonDetailsTests
    {
        private Program _obj;
        private Medicine _medicine;

        [OneTimeSetUp]
        public void Initialize()
        {
            _obj = new Program();
            _medicine = _obj.CreateMedicineDetail("Dolo", "Dolo 250", "Dolo,250", new DateTime(2025, 12, 20), 25);
        }

        [Test]
        [TestCase(20, "12-23-2021", "India")]
        public void CreateCartonDetail_ValidInputs_ExpectedObject(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var result = _obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, _medicine);
            Assert.IsInstanceOf<CartonDetail>(result);
            Assert.AreEqual(medicineStripCount, result.MedicineStripCount);
            Assert.AreEqual(launchDate, result.LaunchDate);
            Assert.AreEqual(retailerAddress, result.RetailerAddress);
        }

        [Test]
        [TestCase(-20, "12-23-2021", "India")]
        public void CreateCartonDetail_MedicineStripCountLessThanZero_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var result = Assert.Throws<Exception>(() => _obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, _medicine));
            Assert.AreEqual("Incorrect strip count. Please check", result.Message);
        }
        [Test]
        [TestCase(20, "12-23-2018", "India")]
        public void CreateCartonDetail_LaunchDateLessThanCurrent_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var result = Assert.Throws<Exception>(() => _obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, _medicine));
            Assert.AreEqual("Incorrect launch date. Please provide valid value", result.Message);
        }

        [Test]
        [TestCase(20, "12-23-2021", "India")]
        public void CreateCartonDetail_NullMedicine_Null(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var result = _obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, null);
            Assert.IsNull(result);
        }

    }
}
