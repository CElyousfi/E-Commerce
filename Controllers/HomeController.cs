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


    //modifff
//abiosda
//vlooog

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
        /// le code corrige 
        public int somme (int a,int b){
 khadijaAB
           

            //Ayoub benabdoulwahid
            //Wissal chakir 
            //Adam Fakak
    <<<<<<< wissalhimmi
            //wissal
  =======
            //Boussakssou Abdessamad
 main
    >>>>>>> main
            return a + b;
          

        }
    }
}
