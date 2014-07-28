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
    public class CustomerControllerTest
    {
        [TestMethod]
        public void Customer_Index_Is_Not_Null()
        {
            // Arrange
            CustomerController controller = new CustomerController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Customer_Details_Returns_A_Customer_Model()
        {
            // Arrange
            CustomerController controller = new CustomerController();
            Customer customer = new Customer();

            // Act
            ViewResult result = controller.Details(customer.CustomerId) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
