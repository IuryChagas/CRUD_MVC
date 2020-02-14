using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUD_MVC.Models;
using CRUD_MVC.Database;

namespace CRUD_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext database;
        public HomeController(ApplicationDBContext database){
            this.database = database;
        }
        public IActionResult Index()
        {
            var accounts = database.Accounts.ToList();
            return View(accounts);
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
    }
}
