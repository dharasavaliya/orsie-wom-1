using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WOM_AuthenticationPortalPrototype2.Models;

namespace WOM_AuthenticationPortalPrototype2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

	public IActionResult About()
        {
            ViewData["Message"] = "Canada’s leading warrior for women’s equality, through entrepreneurship.";
            return View();
        }
    }
}
