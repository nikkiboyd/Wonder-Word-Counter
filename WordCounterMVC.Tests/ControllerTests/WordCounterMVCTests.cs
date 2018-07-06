using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounterMVC.Controllers;

namespace WordCounterMVC.Tests.ControllerTests
{
    [TestClass]
    public class WordCounterMVCControllerTests
    {
        [TestMethod]
        public void Counter_ReturnsCorrectView_True()
        {
            WordCounterMVCController controller = new WordCounterMVCController();
            ActionResult counterView = controller.Counter();
            Assert.IsInstanceOfType(counterView, typeof(ViewResult));
        }

        [TestMethod]
        public void Counter_HasCorrectModelType_True()
        {
            ViewResult counterView = new WordCounterMVCController().Counter() as ViewResult;
            var result = counterView.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void Result_ReturnsCorrectView_True()
        {
            WordCounterMVCController controller = new WordCounterMVCController();
            ActionResult resultView = controller.Result();
            Assert.IsInstanceOfType(resultView, typeof(ViewResult));
        }

        [TestMethod]
        public void Result_HasCorrectModelType_True()
        {
            ViewResult resultView = new WordCounterMVCController().Result() as ViewResult;
            var result = resultView.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void Info_ReturnsCorrectView_True()
        {
            WordCounterMVCController controller = new WordCounterMVCController();
            ActionResult infoView = controller.Info();
            Assert.IsInstanceOfType(infoView, typeof(ViewResult));
        }

        [TestMethod]
        public void Info_HasCorrectModelType_True()
        {
            ViewResult infoView = new WordCounterMVCController().Info() as ViewResult;
            var result = infoView.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
