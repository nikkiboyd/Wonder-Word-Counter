using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet("/word-counter/result")]
        public ActionResult Result()
        {
            return View();
        }

        [HttpPost("/word-counter/result")]
        public ActionResult ShowResult()
        {
            RepeatCounter newCounter = new RepeatCounter((Request.Form["userWord"]), (Request.Form["userSentence"]));
            int occurrences = newCounter.CountOccurrences();
            return View("Result", newCounter);
        }

        [HttpGet("/info")]
        public ActionResult Info()
        {
            return View();
        }
    }
}
