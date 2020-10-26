using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using letscamp.Models;
using System.Net.Http;
using System.Net.Http.Headers;

//EkwRjbPVLXBMl3jZ9pNIDjHirRirT2xOWhSzV8nG NPS API Key
//AIzaSyBC8aiuTyib_sZeR-WejcSWhvDdDsmpJPk Google Maps Map API Key
//8e0dcdf151326cf8b7308ce19005c02c Weather API Key
namespace letscamp.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult Dog()
        {
            return View();
        }

        public class Apihelper
        {
            public static HttpClient ApiClient { get; set; } 

            public static void IntializeClient()
            {
               ApiClient = new HttpClient();
               ApiClient.DefaultRequestHeaders.Accept.Clear();
               ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

    }
}
