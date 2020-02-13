using System;
using Microsoft.AspNetCore.Mvc;
using CRUD_MVC.Models;

namespace CRUD_MVC.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Register(){
            return View();
        }
        
        [HttpPost]
        public IActionResult Save(Account account){
            return Content("Account Number: "+ account.Number +"\nHolder: "+ account.Holder +"\nBalance: "+ account.Balance +"\nEmail: "+ account.Email +"\nAddress: "+ account.Address);
        }
    }
}