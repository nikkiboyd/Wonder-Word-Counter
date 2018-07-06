using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCounterMVC.Models;

namespace WordCounterMVC.Controllers
{
    public class WordCounterMVC : Controller
    {
        [HttpGet("/word-counter")]
        public IActionResult Counter()
        {
            return View();
        }

        [HttpPost("/word-counter/result")]
        public ActionResult Counter(string userWord, string userSentence)
        {
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            newCounter.CountOccurrences(userWord, userSentence);
            return View();
        }
    }
}
