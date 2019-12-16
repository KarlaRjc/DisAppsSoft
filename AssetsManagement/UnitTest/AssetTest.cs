using System;
using AssetsManagement;
using ManejoDeActivos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class AssetTest
    {

        //Create asset with correct information
        [TestMethod]
        public void CreateAssertWithDataOk()
        {
            //Arrange

            string brand = "Dell";
            string model = "Inspiron";
            string series = "1234";
            string state = "Ok";
            string description = "KKK";
            var expectedResult = Asset.CreateAsset("Dell", "Inspiron", "1234", "Ok", "KKK");

            //Act
            var assetResult = Asset.CreateAsset(brand, model, series, state, description);

            //Assert
            Assert.AreNotEqual(expectedResult, assetResult);

        }

        //Create asset to data empty
        [TestMethod]
        public void CreateAssertWithDataEmpty()
        {
            //Arrange

            string brand = String.Empty;
            string model = String.Empty;
            string series = String.Empty;
            string state = String.Empty;
            string description = String.Empty;
            var expectedResult = Asset.CreateAsset("Dell", "Inspiron", "123", "OK", "KKK");

            //Act
            var assetResult = Asset.CreateAsset(brand, model, series, state, description);

            //Assert
            Assert.AreNotEqual(expectedResult, assetResult);

        }



    }
}

