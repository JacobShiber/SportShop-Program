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

        public ActionResult GetLongShirts()
        {
            List<Clothing> longShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.IsShort == false).ToList();
            return View(longShirts);
        }

        public ActionResult GetShortShirts()
        {
            List<Clothing> shortShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.IsShort == true).ToList();
            return View(shortShirts);
        }

        public ActionResult GetDrifitShirts()
        {
            List<Clothing> drifitShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.IsDrifit == true).ToList();
            return View(drifitShirts);
        }

        public ActionResult GetHighToLowMain()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts").OrderByDescending(shirt => shirt.Price).ToList();
            return View(shirtsList);
        }

        public ActionResult GetLowToHighMain()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts").OrderBy(shirt => shirt.Price).ToList();
            return View(shirtsList);
        }

        public ActionResult GetHighToLowLongShirts()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.IsShort == false).OrderByDescending(shirt => shirt.Price).ToList();
            return View(shirtsList);
        }

        public ActionResult GetLowToHighLongShirts()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.IsShort == false).OrderBy(shirt => shirt.Price).ToList();
            return View(shirtsList);
        }

        public ActionResult GetHighToLowShortShirts()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.IsShort == true).OrderByDescending(shirt => shirt.Price).ToList();
            return View(shirtsList);
        }

        public ActionResult GetLowToHighShortShirts()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.IsShort == true).OrderBy(shirt => shirt.Price).ToList();
            return View(shirtsList);
        }

        public ActionResult GetHighToLowDrifitShirts()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.IsDrifit == true).OrderByDescending(shirt => shirt.Price).ToList();
            return View(shirtsList);
        }

        public ActionResult GetLowToHighDrifitShirts()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.IsDrifit == true).OrderBy(shirt => shirt.Price).ToList();
            return View(shirtsList);
        }

        public ActionResult GetPSGShirts()
        {
            List<Clothing> psgShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 1).ToList();
            return View(psgShirts);
        }

        public ActionResult GetHighToLowPSGShirts()
        {
            List<Clothing> psgList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 1).OrderByDescending(shirt => shirt.Price).ToList();
            return View(psgList);
        }

        public ActionResult GetLowToHighPSGShirts()
        {
            List<Clothing> psgList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 1).OrderBy(shirt => shirt.Price).ToList();
            return View(psgList);
        }


        public ActionResult GetLPShirts()
        {
            List<Clothing> lpShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 2).ToList();
            return View(lpShirts);
        }

        public ActionResult GetHighToLowLPShirts()
        {
            List<Clothing> lpList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 2).OrderByDescending(shirt => shirt.Price).ToList();
            return View(lpList);
        }

        public ActionResult GetLowToHighLPShirts()
        {
            List<Clothing> lpList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 2).OrderBy(shirt => shirt.Price).ToList();
            return View(lpList);
        }

        public ActionResult GetTottenhamShirts()
        {
            List<Clothing> tottenhamShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 3).ToList();
            return View(tottenhamShirts);
        }

        public ActionResult GetHighToLowTottenhamShirts()
        {
            List<Clothing> tottenhamShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 3).OrderByDescending(shirt => shirt.Price).ToList();
            return View(tottenhamShirts);
        }

        public ActionResult GetLowToHighTottenhamShirts()
        {
            List<Clothing> tottenhamShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 3).OrderBy(shirt => shirt.Price).ToList();
            return View(tottenhamShirts);
        }

        public ActionResult GetInterShirts()
        {
            List<Clothing> interShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 4).ToList();
            return View(interShirts);
        }

        public ActionResult GetHighToLowInterShirts()
        {
            List<Clothing> interShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 4).OrderByDescending(shirt => shirt.Price).ToList();
            return View(interShirts);
        }

        public ActionResult GetLowToHighInterShirts()
        {
            List<Clothing> interShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 4).OrderBy(shirt => shirt.Price).ToList();
            return View(interShirts);
        }

        public ActionResult GetChelseaShirts()
        {
            List<Clothing> chelseaShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 5).ToList();
            return View(chelseaShirts);
        }

        public ActionResult GetHighToLowChelseaShirts()
        {
            List<Clothing> chelseaShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 5).OrderByDescending(shirt => shirt.Price).ToList();
            return View(chelseaShirts);
        }

        public ActionResult GetLowToHighChelseaShirts()
        {
            List<Clothing> chelseaShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 5).OrderBy(shirt => shirt.Price).ToList();
            return View(chelseaShirts);
        }

        public ActionResult GetRMShirts()
        {
            List<Clothing> chelseaShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 6).ToList();
            return View(chelseaShirts);
        }

        public ActionResult GetHighToLowRMShirts()
        {
            List<Clothing> chelseaShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 6).OrderByDescending(shirt => shirt.Price).ToList();
            return View(chelseaShirts);
        }

        public ActionResult GetLowToHighRMShirts()
        {
            List<Clothing> chelseaShirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts" && item.TeamId == 6).OrderBy(shirt => shirt.Price).ToList();
            return View(chelseaShirts);
        }





        public ActionResult GetOnlyNikeAdmin()
        {
            List<Clothing> nikeShirts = dataContext.Clothings.Where(item => item.Brand == "Nike" && item.ClothingType == "Shirts").ToList();
            return View(nikeShirts);
        }

        public ActionResult GetOnlyAdidasAdmin()
        {
            List<Clothing> adidasShirts = dataContext.Clothings.Where(item => item.Brand == "Adidas" && item.ClothingType == "Shirts").ToList();
            return View(adidasShirts);
        }

        public ActionResult GetOnlyNBAdmin()
        {
            List<Clothing> nbShirts = dataContext.Clothings.Where(item => item.Brand == "New Balance" && item.ClothingType == "Shirts").ToList();
            return View(nbShirts);
        }

        public ActionResult GetPriceHighToLowMainAdmin()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts").OrderByDescending(shirt => shirt.Price).ToList();
            return View(shirtsList);
        }

        public ActionResult GetPriceHighToLowNikeAdmin()
        {
            List<Clothing> nikeShirts = dataContext.Clothings.Where(item => item.Brand == "Nike" && item.ClothingType == "Shirts").OrderByDescending(shirt => shirt.Price).ToList();
            return View(nikeShirts);
        }

        public ActionResult GetPriceHighToLowAdidasAdmin()
        {
            List<Clothing> adidasShirts = dataContext.Clothings.Where(item => item.Brand == "Adidas" && item.ClothingType == "Shirts").OrderByDescending(shirt => shirt.Price).ToList();
            return View(adidasShirts);
        }

        public ActionResult GetPriceHighToLowNBAdmin()
        {
            List<Clothing> nbShirts = dataContext.Clothings.Where(item => item.Brand == "New Balance" && item.ClothingType == "Shirts").OrderByDescending(shirt => shirt.Price).ToList();
            return View(nbShirts);
        }

        public ActionResult GetPriceLowToHighMainAdmin()
        {
            List<Clothing> shirtsList = dataContext.Clothings.Where(item => item.ClothingType == "Shirts").OrderBy(shoe => shoe.Price).ToList();
            return View(shirtsList);
        }

        public ActionResult GetPriceLowToHighNikeAdmin()
        {
            List<Clothing> nikeShirts = dataContext.Clothings.Where(item => item.Brand == "Nike" && item.ClothingType == "Shirts").OrderBy(shirt => shirt.Price).ToList();
            return View(nikeShirts);
        }

        public ActionResult GetPriceLowToHighAdidasAdmin()
        {
            List<Clothing> adidasShirts = dataContext.Clothings.Where(item => item.Brand == "Adidas" && item.ClothingType == "Shirts").OrderBy(shirt => shirt.Price).ToList();
            return View(adidasShirts);
        }

        public ActionResult GetPriceLowToHighNBAdmin()
        {
            List<Clothing> nbShirts = dataContext.Clothings.Where(item => item.Brand == "New Balance" && item.ClothingType == "Shirts").OrderBy(shirt => shirt.Price).ToList();
            return View(nbShirts);
        }
    }
}