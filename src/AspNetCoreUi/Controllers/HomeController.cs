using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCoreUi.Models;
using AspNetCoreUi.Infrastructure;
using Microsoft.EntityFrameworkCore;
using AspNetCoreUi.Services;

namespace AspNetCoreUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Task: Update the application home page to show a list of rover images using the NASA Service to fetch the data
            return View();
        }

        //Task: Add a new action/view that returns a page with a list of people. It should keep the theme
        //of the application

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
