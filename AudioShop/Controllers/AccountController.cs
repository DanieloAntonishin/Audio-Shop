using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AudioShop.Models;
using BusinessLogic;
using BusinessLogic.Entities;
using AutoMapper;


namespace AudioShop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(AccountModel account)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BL())
                    db.AddAccount(Mapper.Map<AccountBL>(account));

                return Redirect("~/Home/Index");
            }
            return View();
        }
        public IActionResult SignUp()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SignUp(AccountModelSignUp account)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BL())
                {
                    foreach (var acc in db.GetAccounts())
                    {
                        if (acc.Login == account.Login && acc.Password == account.Password)
                        {
                            return Redirect("~/Home/Index");
                        }
                    }
                }
            }
            ModelState.AddModelError("Role", "Account not found");
            return View();
        }
    }
}
