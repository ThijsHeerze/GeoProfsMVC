﻿using GeoProfs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GeoProfs.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Verlof()
        {
            return View();
        }
        public IActionResult Login()
        { 
            return View();
        }
        public IActionResult Manager()
        {
            return View();
        }

        public IActionResult Schoonmaker()
        {
            return View();
        }
        public IActionResult Medewerker()
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