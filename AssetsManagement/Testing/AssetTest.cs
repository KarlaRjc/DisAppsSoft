using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssetsManagement;

namespace Testing
{
    [TestClass]
    public class AssetTest
    {
        [TestMethod]
        public void CreateAssertWithDataOk()
        {
            //Arrange
            int id = 1;
            string brand = "Dell";
            string model = "Inspiron";
            string series = "1234";
            string state = "Ok";
            string description = "KKK";
            var expectedResult = Asset.CreateAsset(1, "Dell", "Inspiron", "1234", "Ok", "KKK");

            //Act
            var assetResult = Asset.CreateAsset(id, brand, model, series, state, description);

            //Assert
            Assert.AreNotEqual(expectedResult, assetResult);

        }

        [TestMethod]
        public void CreateAssertWithDataEmpty()
        {
            //Arrange
            int id = 0;
            string brand = String.Empty;
            string model = String.Empty;
            string series = String.Empty;
            string state = String.Empty;
            string description = String.Empty;
            var expectedResult = Asset.CreateAsset(1, "Dell", "Inspiron", "123", "OK", "KKK");

            //Act
            var assetResult = Asset.CreateAsset(id, brand, model, series, state, description);

            //Assert
            Assert.AreNotEqual(expectedResult, assetResult);

        }

    }
}
