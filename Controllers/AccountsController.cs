using System;
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
        public IActionResult Register(){
            return View();
        }
        
        [HttpPost]
        public IActionResult Save(Account account){
            database.Accounts.Add(account);
            database.SaveChanges();

            return Content("Account Number: "+ account.Number +"\nHolder: "+ account.Holder +"\nBalance: "+ account.Balance +"\nEmail: "+ account.Email +"\nAddress: "+ account.Address);
        }
    }
}