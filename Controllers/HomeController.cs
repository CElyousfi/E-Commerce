using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{


//SARA ZAIM SASSI

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
        /// le code corrige <summary>
        /// le code corrige
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns> 
        /// corrige par soufian chahir
        public int somme(int a, int b)
        {

            int s = a / b;
            //GFD

            return s + b;




            {
                //Ayoub benabdoulwahid
                //Wissal chakir



            }
        }
    }
}
