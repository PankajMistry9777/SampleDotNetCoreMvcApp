using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleDotNetCoreMvcApp.Models;

namespace SampleDotNetCoreMvcApp.Controllers
{
	 public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to your .NET Core App!";
            return View();
        }

        public IActionResult SampleData()
        {
            var data = new List<string> { "Item 1", "Item 2", "Item 3","Item 5", "Item 6", "Item 5555" };
            return Json(data);
        }
 	public IActionResult SampleData2()
        {
            var data = new List<string> { "Item 1", "Item 2", "Item 3","Item 5", "Item 6", "Item 7" };
            return Json(data);
        }
public IActionResult SampleData22()
        {
            var data = new List<string> { "Item 1", "Item 2", "Item 3","Item 5", "Item 6", "Item 7" };
            return Json(data);
        }


    }  
}
