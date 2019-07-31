using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DBL;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WOM_AuthenticationPortalPrototype2.Controllers
{
    [Authorize(Roles = "Client")]
    public class ClientController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            
             ViewData["Message"] = "Student Dashboard";
            return View();

        }

        public IActionResult StudentCourseList()
        {
            ViewData["Message"] = "Path of Career Enlightenment";
            return View();
        }

        public IActionResult StudentCourseInfo()
        {
            ViewData["Message"] = "Course Outlines";
            return View();
        }

        public IActionResult StudentClassInfo()
        {
            ViewData["Message"] = "Class - 1";
            return View();
        }
    }
        
        
    
}
