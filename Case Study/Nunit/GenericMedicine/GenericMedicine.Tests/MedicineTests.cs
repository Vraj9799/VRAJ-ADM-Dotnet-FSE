using NUnit.Framework;
using System;

namespace GenericMedicine.Tests
{
    [TestFixture]
    public class MedicineTests
    {
        private Program _obj;

        [OneTimeSetUp]
        public void Initialize()
        {
            _obj = new Program();
        }

        [Test]
        [TestCase("Dolo", "Dolo 250", "Dolo,250", "12-12-2022", 20)]
        public void CreateMedicine_ValidInputs_ExpectedObject(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var result = _obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);
            Assert.IsInstanceOf<Medicine>(result);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(genericMedicineName, result.GenericMedicineName);
            Assert.AreEqual(composition, result.Composition);
            Assert.AreEqual(expiryDate, result.ExpiryDate);
            Assert.AreEqual(pricePerStrip, result.PricePerStrip);
        }

        [Test]
        [TestCase("Dolo", null, "Dolo,250", "12-12-2022", 20)]
        [TestCase("Dolo", "", "Dolo,250", "12-12-2022", 20)]
        //[TestCase("Dolo", "Generic", "Dolo,250", "12-12-2022", 20)]
        public void CreateMedicine_InvalidGenericName_Exception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var result = Assert.Throws<Exception>(() => _obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Generic Medicine name cannot be empty. Please provide valid value", result.Message);
        }
        [Test]
        [TestCase("Dolo", "Dolo 250", "Dolo,250", "12-12-2022", -20)]
        [TestCase("Dolo", "Dolo 250", "Dolo,250", "12-12-2022", 0)]
        //[TestCase("Dolo", "Dolo 250", "Dolo,250", "12-12-2022", 20)]
        public void CreateMedicine_PriceLessThanZero_Exception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var result = Assert.Throws<Exception>(() => _obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", result.Message);
        }

        [Test]
        [TestCase("Dolo", "Dolo 250", "Dolo,250", "12-12-2018", 20)]
        //[TestCase("Dolo", "Dolo 250", "Dolo,250", "12-23-2022", 20)]
        public void CreateMedicine_InvalidExpiryDate_Exception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var result = Assert.Throws<Exception>(() => _obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", result.Message);
        }

    }
}
