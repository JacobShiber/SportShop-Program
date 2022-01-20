using SportShop_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportShop_Program.Controllers
{
    public class ShoesController : Controller
    {
        SportShopContextDataContext dataContext = new SportShopContextDataContext();
        // GET: Shoes
        public ActionResult Index()
        {
            List<Shoe> shoesList = dataContext.Shoes.ToList();
            return View(shoesList);
        }

        public ActionResult GetSales()
        {
            List<Shoe> shoesInSale = dataContext.Shoes.Where(shoe => shoe.IsInSale == true).ToList();
            return View(shoesInSale);
        }

        public ActionResult GetAdminView()
        {
            List<Shoe> shoesList = dataContext.Shoes.ToList();
            return View(shoesList);
        }
    }
}