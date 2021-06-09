using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _selerService;

        public SellersController(SellerService selerService)
        {
            _selerService = selerService;
        }
        public IActionResult Index()
        {
            var list = _selerService.FindAll();
            return View(list);
        }
    }
}
