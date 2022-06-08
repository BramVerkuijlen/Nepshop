using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NepshopApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Nepshop.Logic;
using Nepshop.DAL;
using Nepshop.Logic.Model.DTO;
using Nepshop.Logic.Interface;

namespace NepshopApp.Controllers
{
    public class HomeController : Controller
    {
        readonly IProductMaintainerDal ProductMaintainerDAL;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IProductMaintainerDal productMaintainerDal)
        {
            _logger = logger;
            ProductMaintainerDAL = productMaintainerDal;
        }

        public IActionResult Index(ProductDal productDal)
        {
            ProductMaintainer productMaintainer = new ProductMaintainer(productDal);
            List<ProductDTO>products = productMaintainer.GetAllProducts();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
