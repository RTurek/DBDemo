using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OGSys.Web;
using OGSys.Web.Controllers;
using OGSys.Web.Models;

namespace OGSys.Web.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void Login_Returns_View()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.Login("") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Register_Returns_View()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.Register() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Forgot_Password_Returns_View()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.ForgotPassword() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Reset_Password_Returns_View()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.ResetPassword("") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Reset_Password_Confirmation_Returns_View()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.ResetPasswordConfirmation() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ExternalLoginFailure_Returns_View()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.ExternalLoginFailure() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }



    }
}
