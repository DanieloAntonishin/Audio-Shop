using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using AudioShop.Models;
using AutoMapper;

namespace AudioShop.Controllers
{
    public class StoreController : Controller
    {
        public List<ProductModel> headpones = new List<ProductModel>();
        public IActionResult Headpones()
        {
            using (var db = new BL())
            {
                headpones = Mapper.Map<List<ProductModel>>(db.GetProducts().Where(x => x.Category == "Headpones"));
            }
                return View(headpones);
        }
        public IActionResult Soundbar()
        {
            return View();
        }
        public IActionResult Speaker()
        {
            return View();
        }
    }
}
