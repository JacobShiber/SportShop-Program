using SportShop_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportShop_Program.Controllers
{
    public class GearController : Controller
    {
        SportShopContextDataContext dataContext = new SportShopContextDataContext();
        // GET: Gear
        public ActionResult Index()
        {
            List<Gear> gearList = dataContext.Gears.ToList();
            return View(gearList);
        }

        public ActionResult GetBBgear()
        {
            List<Gear> bbList = dataContext.Gears.Where(item => item.SportType == "Basketball").ToList();
            return View(bbList);
        }

        public ActionResult GetFBgear()
        {
            List<Gear> fbList = dataContext.Gears.Where(item => item.SportType == "Football").ToList();
            return View(fbList);
        }

        public ActionResult GetPSGgear()
        {
            List<Gear> psgGear = dataContext.Gears.Where(item => item.TeamId == 1).ToList();
            return View(psgGear);
        }

        public ActionResult GetRMgear()
        {
            List<Gear> rmGear = dataContext.Gears.Where(item => item.TeamId == 6).ToList();
            return View(rmGear);
        }

         

        public ActionResult GetHighToLowMain()
        {
            List<Gear> gearList = dataContext.Gears.OrderByDescending(gear => gear.Price).ToList();
            return View(gearList);
        }

        public ActionResult GetLowToHighMain()
        {
            List<Gear> gearList = dataContext.Gears.OrderBy(gear => gear.Price).ToList();
            return View(gearList);
        }

        
        public ActionResult GetHighToLowBB()
        {
            List<Gear> bbList = dataContext.Gears.Where(item => item.SportType == "Basketball").OrderByDescending(gear => gear.Price).ToList();
            return View(bbList);
        }

        public ActionResult GetLowToHighBB()
        {
            List<Gear> bbList = dataContext.Gears.Where(item => item.SportType == "Basketball").OrderBy(gear => gear.Price).ToList();
            return View(bbList);
        }

        public ActionResult GetHighToLowFB()
        {
            List<Gear> fbList = dataContext.Gears.Where(item => item.SportType == "Football").OrderByDescending(gear => gear.Price).ToList();
            return View(fbList);
        }

        public ActionResult GetLowToHighFB()
        {
            List<Gear> fbList = dataContext.Gears.Where(item => item.SportType == "Football").OrderBy(gear => gear.Price).ToList();
            return View(fbList);
        }

        

        public ActionResult GetHighToLowPSG()
        {
            List<Gear> psgList = dataContext.Gears.Where(item => item.TeamId == 1).OrderByDescending(gear => gear.Price).ToList();
            return View(psgList);
        }

        public ActionResult GetLowToHighPSG()
        {
            List<Gear> psgList = dataContext.Gears.Where(item => item.TeamId == 1).OrderBy(gear => gear.Price).ToList();
            return View(psgList);
        }

        

        public ActionResult GetHighToLowRM()
        {
            List<Gear> rmList = dataContext.Gears.Where(item => item.TeamId == 6).OrderByDescending(gear => gear.Price).ToList();
            return View(rmList);
        }

        public ActionResult GetLowToHighRM()
        {
            List<Gear> rmList = dataContext.Gears.Where(item => item.TeamId == 6).OrderBy(gear => gear.Price).ToList();
            return View(rmList);
        }

        //todo 

        public ActionResult GetAdminView()
        {
            List<Gear> gearListAdmin = dataContext.Gears.ToList();
            return View(gearListAdmin);
        }


        public ActionResult GetOnlyBBAdmin()
        {
            List<Gear> bbListAdmin = dataContext.Gears.Where(item => item.SportType == "Basketball").ToList();
            return View(bbListAdmin);
        }

        public ActionResult GetOnlyFBAdmin()
        {
            List<Gear> fbListAdmin = dataContext.Gears.Where(item => item.SportType == "Football").ToList();
            return View(fbListAdmin);
        }


        public ActionResult GetPriceHighToLowMainAdmin()
        {
            List<Gear> gearListAdmin = dataContext.Gears.OrderByDescending(item => item.Price).ToList();
            return View(gearListAdmin);
        }

        public ActionResult GetPriceLowToHighMainAdmin()
        {
            List<Gear> gearListAdmin = dataContext.Gears.OrderBy(item => item.Price).ToList();
            return View(gearListAdmin);
        }


        public ActionResult GetPriceHighToLowBBAdmin()
        {
            List<Gear> bbListAdmin = dataContext.Gears.Where(item => item.SportType == "Basketball").OrderByDescending(gear => gear.Price).ToList();
            return View(bbListAdmin);
        }

        public ActionResult GetPriceLowToHighBBAdmin()
        {
            List<Gear> bbListAdmin = dataContext.Gears.Where(item => item.SportType == "Basketball").OrderBy(gear => gear.Price).ToList();
            return View(bbListAdmin);
        }


        public ActionResult GetPriceHighToLowFBAdmin()
        {
            List<Gear> fbListAdmin = dataContext.Gears.Where(item => item.SportType == "Football").OrderByDescending(gear => gear.Price).ToList();
            return View(fbListAdmin);
        }

        public ActionResult GetPriceLowToHighFBAdmin()
        {
            List<Gear> fbListAdmin = dataContext.Gears.Where(item => item.SportType == "Football").OrderBy(gear => gear.Price).ToList();
            return View(fbListAdmin);
        }

    }
}