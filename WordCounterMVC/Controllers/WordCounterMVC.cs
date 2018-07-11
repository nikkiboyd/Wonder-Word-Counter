using Microsoft.AspNetCore.Mvc;
using WordCounterMVC.Models;

namespace WordCounterMVC.Controllers
{
    public class WordCounterMVCController : Controller
    {
        [HttpGet("/word-counter")]
        public ActionResult Counter()
        {
            return View();
        }


        [HttpPost("/word-counter/result")]
        public ActionResult Result(string userWord, string userSentence)
        {
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int occurrences = newCounter.CountOccurrences();
            return View(newCounter);
        }

        [HttpGet("/info")]
        public ActionResult Info()
        {
            return View();
        }
    }
}
