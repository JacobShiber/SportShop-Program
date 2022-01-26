using SportShop_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportShop_Program.Controllers
{
    public class ShirtsController : Controller
    {
        SportShopContextDataContext dataContext = new SportShopContextDataContext();
        // GET: Shirts
        public ActionResult Index()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts").ToList();
            return View(shirtsList);
        }

        public ActionResult GetAdminView()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts").ToList();
            return View(shirtsList);
        }
    }
}