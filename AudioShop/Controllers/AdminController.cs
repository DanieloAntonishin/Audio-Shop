using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using AudioShop.Models;
using BusinessLogic;
using BusinessLogic.Entities;
using AutoMapper;
using System.IO;

namespace AudioShop.Controllers
{
    public class AdminController : Controller
    {
        IWebHostEnvironment _appEnvironment;
        public AdminController(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        public IActionResult AdminPanel()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdminPanel(ProductModel product, IFormFile UploadFile)
        {
            if (UploadFile != null)
            {
                string path = "/products/" + UploadFile.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await UploadFile.CopyToAsync(fileStream);
                }
                product.Image = path;
                using (var db = new BL())
                {
                    db.AddProduct(Mapper.Map<ProductBL>(product));
                }
                return Redirect("~/Home/Index");
            }
            else
            {
                return View();
            }
        }

    }
}
