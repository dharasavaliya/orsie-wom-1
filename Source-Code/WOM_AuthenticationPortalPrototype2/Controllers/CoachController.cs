using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WOM_AuthenticationPortalPrototype2.Controllers
{
    [Authorize(Roles = "Coach")]
    public class CoachController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

	public IActionResult CheckStudentProgress()
        {
            ViewData["Message"] = "Check Student Progress";
            return View();

        }
    }
}
