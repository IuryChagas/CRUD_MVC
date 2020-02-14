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

        public IActionResult Edit(int id){
            Account account = database.Accounts.First(register => register.Id == id);
            return View("register", account);
        }
        public IActionResult Delete(int id){
            Account account = database.Accounts.First(register => register.Id == id);
            database.Accounts.Remove(account);
            database.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Save(Account account){
            if (account.Id == 0)
            {
                database.Accounts.Add(account);
            }else{
                Account holderAtBank = database.Accounts.First(register => register.Id == account.Id);

                holderAtBank.Number = account.Number;
                holderAtBank.Holder = account.Holder ;
                holderAtBank.Balance = account.Balance ;
                holderAtBank.Email = account.Email ;
                holderAtBank.Address = account.Address ;
            }
            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}