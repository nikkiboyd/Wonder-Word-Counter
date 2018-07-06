using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WordCounterMVC.Controllers
{
    public class WordCounterMVC : Controller
    {
        [HttpGet("/word-counter")]
        public IActionResult Counter()
        {
            return View();
        }
    }
}
