using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssetsManagement;
using ManejoDeActivos;

namespace Testing
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void CreateUserWithDataOk()
        {
            //Arrange
            int id = 1;
            string name = "Denis";
            EnumRole role = EnumRole.Admin;
            string username = "dugalde";
            string password = "123";
            var expectedResult = User.CreateUser(1, "Denis", EnumRole.Admin, "dugalde", "123");

            //Act
            var result = User.CreateUser(id, name, role, username, password);

            //Assert
            Assert.AreNotEqual(expectedResult, result);

        }

        [TestMethod]
        public void CreateUserWithNegativeId()
        {
            //Arrange
            int id = -2;
            string name = "Denis";
            EnumRole role = EnumRole.Admin;
            string username = "dugalde";
            string password = "123";
            var expectedResult = User.CreateUser(-1, "Denis", EnumRole.Admin, "dugalde", "123");

            //Act
            var result = User.CreateUser(id, name, role, username, password);

            //Assert
            Assert.AreNotEqual(expectedResult, result);

        }

        [TestMethod]
        public void CreateUserWithDataEmpty()
        {
            //Arrange
            int id = 0;
            string name = string.Empty;
            EnumRole role = EnumRole.Admin;
            string username = string.Empty;
            string password = string.Empty;
            var expectedResult = User.CreateUser(1, "Denis", EnumRole.Admin, "dugalde", "123");

            //Act
            var result = User.CreateUser(id, name, role, username, password);

            //Assert
            Assert.AreNotEqual(expectedResult, result);

        }

        [TestMethod]
        public void CreateUserWithDecimal()
        {
            //Arrange
            int id = Convert.ToInt32(12.36);
            string name = "Denis";
            EnumRole role = EnumRole.Admin;
            string username = "dugalde";
            string password = "123";
            var expectedResult = User.CreateUser(1, "Denis", EnumRole.Admin, "dugalde", "123");

            //Act
            var result = User.CreateUser(id, name, role, username, password);

            //Assert
            Assert.AreNotEqual(expectedResult, result);

        }

        [TestMethod]
        public void CreateUserIdwithArithmeticOperations()
        {
            //Arrange
            int id = 12 / 3;
            string name = "Denis";
            EnumRole role = EnumRole.Admin;
            string username = "dugalde";
            string password = "123";
            var expectedResult = User.CreateUser(1, "Denis", EnumRole.Admin, "dugalde", "123");

            //Act
            var result = User.CreateUser(id, name, role, username, password);

            //Assert
            Assert.AreNotEqual(expectedResult, result);

        }
    }
}