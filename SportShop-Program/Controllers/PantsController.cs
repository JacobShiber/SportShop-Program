using SportShop_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportShop_Program.Controllers
{
    public class PantsController : Controller
    {
        SportShopContextDataContext dataContext = new SportShopContextDataContext();
        // GET: Pants
        public ActionResult Index()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants").ToList();
            return View(pantsList);
        }

        public ActionResult GetLongPants()
        {
            List<Clothing> longPants = dataContext.Clothings.Where(item => item.ClothingType == "Pants" && item.IsShort == false).ToList();
            return View(longPants);
        }

        public ActionResult GetShortPants()
        {
            List<Clothing> shortPants = dataContext.Clothings.Where(item => item.ClothingType == "Pants" && item.IsShort == true).ToList();
            return View(shortPants);
        }

        public ActionResult GetDrifitPants()
        {
            List<Clothing> drifitPants = dataContext.Clothings.Where(item => item.ClothingType == "Pants" && item.IsDrifit == true).ToList();
            return View(drifitPants);
        }




        public ActionResult GetHighToLowMain()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants").OrderByDescending(pants => pants.Price).ToList();
            return View(pantsList);
        }

        public ActionResult GetLowToHighMain()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants").OrderBy(pants => pants.Price).ToList();
            return View(pantsList);
        }

        public ActionResult GetHighToLowLongPants()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants" && item.IsShort == false).OrderByDescending(pants => pants.Price).ToList();
            return View(pantsList);
        }

        public ActionResult GetLowToHighLongPants()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants" && item.IsShort == false).OrderBy(pants => pants.Price).ToList();
            return View(pantsList);
        }

        public ActionResult GetHighToLowShortPants()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants" && item.IsShort == true).OrderByDescending(pants => pants.Price).ToList();
            return View(pantsList);
        }

        public ActionResult GetLowToHighShortPants()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants" && item.IsShort == true).OrderBy(pants => pants.Price).ToList();
            return View(pantsList);
        }

        public ActionResult GetHighToLowDrifitPants()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants" && item.IsDrifit == true).OrderByDescending(pants => pants.Price).ToList();
            return View(pantsList);
        }

        public ActionResult GetLowToHighDrifitPants()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants" && item.IsDrifit == true).OrderBy(pants => pants.Price).ToList();
            return View(pantsList);
        }





        public ActionResult GetAdminView()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants").ToList();
            return View(pantsList);
        }


        public ActionResult GetOnlyNikeAdmin()
        {
            List<Clothing> nikePants = dataContext.Clothings.Where(item => item.Brand == "Nike" && item.ClothingType == "Pants").ToList();
            return View(nikePants);
        }

        public ActionResult GetOnlyAdidasAdmin()
        {
            List<Clothing> adidasPants = dataContext.Clothings.Where(item => item.Brand == "Adidas" && item.ClothingType == "Pants").ToList();
            return View(adidasPants);
        }

        public ActionResult GetOnlyNBAdmin()
        {
            List<Clothing> nbPants = dataContext.Clothings.Where(item => item.Brand == "New Balance" && item.ClothingType == "Pants").ToList();
            return View(nbPants);
        }

        
        public ActionResult GetPriceHighToLowMainAdmin()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants").OrderByDescending(pants => pants.Price).ToList();
            return View(pantsList);
        }

        public ActionResult GetPriceLowToHighMainAdmin()
        {
            List<Clothing> pantsList = dataContext.Clothings.Where(item => item.ClothingType == "Pants").OrderBy(shoe => shoe.Price).ToList();
            return View(pantsList);
        }

        
        public ActionResult GetPriceHighToLowNikeAdmin()
        {
            List<Clothing> nikePants = dataContext.Clothings.Where(item => item.Brand == "Nike" && item.ClothingType == "Pants").OrderByDescending(pants => pants.Price).ToList();
            return View(nikePants);
        }

        public ActionResult GetPriceLowToHighNikeAdmin()
        {
            List<Clothing> nikePants = dataContext.Clothings.Where(item => item.Brand == "Nike" && item.ClothingType == "Pants").OrderBy(pants => pants.Price).ToList();
            return View(nikePants);
        }

        
        public ActionResult GetPriceHighToLowAdidasAdmin()
        {
            List<Clothing> adidasPants = dataContext.Clothings.Where(item => item.Brand == "Adidas" && item.ClothingType == "Pants").OrderByDescending(pants => pants.Price).ToList();
            return View(adidasPants);
        }

        public ActionResult GetPriceLowToHighAdidasAdmin()
        {
            List<Clothing> adidasPants = dataContext.Clothings.Where(item => item.Brand == "Adidas" && item.ClothingType == "Pants").OrderBy(pants => pants.Price).ToList();
            return View(adidasPants);
        }


        public ActionResult GetPriceHighToLowNBAdmin()
        {
            List<Clothing> nbPants = dataContext.Clothings.Where(item => item.Brand == "New Balance" && item.ClothingType == "Pants").OrderByDescending(pants => pants.Price).ToList();
            return View(nbPants);
        }
        

        public ActionResult GetPriceLowToHighNBAdmin()
        {
            List<Clothing> nbPants = dataContext.Clothings.Where(item => item.Brand == "New Balance" && item.ClothingType == "Pants").OrderBy(pants => pants.Price).ToList();
            return View(nbPants);
        }
    }
}
