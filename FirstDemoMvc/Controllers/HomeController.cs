using FirstDemoMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstDemoMvc.Controllers
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
            //ViewData-->

            ViewData["message"] = "This is Employee names in view Data";
            List<string> names = new List<string>()
            {
                "Sandesh","Raj","Rushi","Shubham","Rohit"
            };
            ViewData["list"] = names;//implict-->object


            ViewData["message2"] = "This is City names in view Data";
            List<string> Cities = new List<string>()
            {
                "Pune","Mumbai","Nagar","Solapur","Kolhapur"
            };
            ViewData["list2"] = Cities;


            //Working with viewBag--> When we add ViewBag we need to creste new property
            ViewBag.Month = "Jan";
            ViewBag.year = 2023;
            ViewBag.Names = names;

            //TempData
            TempData["Company"] = "Think Quotient" ;
            TempData.Keep("Company");


            return View();
        }

        public IActionResult Privacy()
        {
            var name = TempData["Company"];
            //remove the value from tempData
            TempData.Clear();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult  ContactUs()
        {
            return View();
        }
    }
}