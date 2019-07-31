using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WOM_AuthenticationPortalPrototype2.Controllers
{
    public class DiscussionController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Discussion";
            return View();
        }

        public IActionResult DiscussionList()
        {
            ViewData["Message"] = "Start a New Thread";
            return View();
        }

        public IActionResult CheckProgress()
        {
            ViewData["Message"] = "Check Progress";
            return View();
        }
        public IActionResult Quiz()
        {
            ViewData["Message"] = "Check Progress";
            return View();
        }
    }
}