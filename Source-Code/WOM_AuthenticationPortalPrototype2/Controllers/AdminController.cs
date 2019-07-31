using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WOM_AuthenticationPortalPrototype2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

public IActionResult ManageUsers()
        {
            ViewData["Message"] = "Manage Users Profiles";
            return View();
        }

        // Client Admin Controllers 
        public IActionResult UpdateDisableClient()
        {
            return View();
        }

        public IActionResult UpdateDisableClientMain()
        {
            return View();
        }

        public IActionResult AddClientToCourse()
        {
            return View();
        }

        public IActionResult ViewAllClients()
        {
            return View();
        }

        // Client Coach Controllers
        public IActionResult ViewAllCoaches()
        {
            return View();
        }

        public IActionResult UpdateDisableCoach()
        {
            return View();
        }

        // Programs Controller
        public IActionResult AddNewProgram()
        {
            return View();
        }

        public IActionResult UpdateDeactivateProgram()
        {
            return View();
        }

        public IActionResult ViewAllPrograms()
        {
            return View();
        }
    }
}
