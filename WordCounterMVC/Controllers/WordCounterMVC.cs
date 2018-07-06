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
        public ActionResult Counter()
        {
            return View();
        }

        [HttpGet("/word-counter/result")]
        public ActionResult Result()
        {
            return View();
        }


        [HttpPost("/word-counter/result")]
        public ActionResult Result(string userWord, string userSentence)
        {
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            newCounter.CountOccurrences(userWord, userSentence);
            return View(newCounter.CountOccurrences(userWord, userSentence));
        }
    }
}
