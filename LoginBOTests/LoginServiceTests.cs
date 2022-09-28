using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoginBO;
using System;
using System.Collections.Generic;
using System.Text;
using ServicesPackage;
using Domain.ViewObjects.LoginServiceVO;
using Moq;

namespace LoginBO.Tests
{
    [TestClass()]
    public class LoginServiceTests
    {
        [TestMethod()]
        public void Test_Login()
        {
            //Arrange
            ILoginService target = new LoginService();
            IAccount account = new Account();
            bool? expected = true;
            bool? actual;

            //Act
            actual = target.Login(account);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
