﻿using Demo01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo01.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // /Home/DitBonjour
        public string DitBonjour()
        {
            return "Bonjour à toi !";
        }

        // /Home/DitBonjourA?personne=Guillaume
        public string DitBonjourA(string personne)
        {
            return $"Bonjour à toi {personne}!";
        }

        // /Home/Compter?id=15
        // /Home/Compter/15
        public string Compter(int id)
        {
            string chaine = "";
            for (int i = 0; i < id; i++)
            {
                chaine += i + ", ";
            }
            return $"Compte : {chaine}!";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}