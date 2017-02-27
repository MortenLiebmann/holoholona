using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Holoholona.Controllers;
using System;

namespace Holoholona.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Test_HomeView_return_index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("", result.ViewName);
        }
    }
}