﻿using Microsoft.AspNetCore.Mvc;
using mvc_first_proj.Models;
using System.Diagnostics;

namespace mvc_first_proj.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Faculty_Dashbord()
        {
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        //public IActionResult Contact() {

        //  return View("Contact_Page");
        
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}