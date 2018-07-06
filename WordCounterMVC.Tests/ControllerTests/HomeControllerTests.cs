using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCounterMVC.Controllers;
using WordCounterMVC.Models;

namespace WordCounterMVC.Tests.ControllerTests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            HomeController controller = new HomeController();
            ActionResult indexView = controller.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
    }
}
