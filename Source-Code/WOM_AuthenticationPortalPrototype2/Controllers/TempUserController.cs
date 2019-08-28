using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WOM_AuthenticationPortalPrototype2.Controllers
{
    public class TempUserController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Become Women Entrepreneurs";
            return View();
        }
    }
}