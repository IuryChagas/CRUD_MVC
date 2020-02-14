using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CRUD_MVC.Models;
using CRUD_MVC.Database;

namespace CRUD_MVC.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ApplicationDBContext database;
        public AccountsController(ApplicationDBContext database){
            this.database = database;
        }
        public IActionResult Index(){
            var accounts = database.Accounts.ToList();
            return View(accounts);
        }
        public IActionResult Register(){
            return View();
        }
        
        [HttpPost]
        public IActionResult Save(Account account){
            database.Accounts.Add(account);
            database.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}