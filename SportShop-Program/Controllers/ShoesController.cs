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

        public ActionResult GetOnlyNike()
        {
            List<Shoe> nikeShoes = dataContext.Shoes.Where(shoe => shoe.Brand == "Nike").ToList();
            return View(nikeShoes);
        }

        public ActionResult GetOnlyAdidas()
        {
            List<Shoe> adidasShoes = dataContext.Shoes.Where(shoe => shoe.Brand == "Adidas").ToList();
            return View(adidasShoes);
        }

        public ActionResult GetOnlyNB()
        {
            List<Shoe> nbShoes = dataContext.Shoes.Where(shoe => shoe.Brand == "New Balance").ToList();
            return View(nbShoes);
        }

        public ActionResult GetPriceHighToLowMain()
        {
            List<Shoe> shoesList = dataContext.Shoes.OrderByDescending(shoe => shoe.Price).ToList();
            return View(shoesList);
        }

        public ActionResult GetPriceHighToLowNike()
        {
            List<Shoe> onlyNike = dataContext.Shoes.Where(shoe => shoe.Brand == "Nike").OrderByDescending(shoe => shoe.Price).ToList();
            return View(onlyNike);
        }

        public ActionResult GetPriceHighToLowAdidas()
        {
            List<Shoe> onlyAdidas = dataContext.Shoes.Where(shoe => shoe.Brand == "Adidas").OrderByDescending(shoe => shoe.Price).ToList();
            return View(onlyAdidas);
        }

        public ActionResult GetPriceHighToLowNB()
        {
            List<Shoe> onlyNB = dataContext.Shoes.Where(shoe => shoe.Brand == "New Balance").OrderByDescending(shoe => shoe.Price).ToList();
            return View(onlyNB);
        }

        public ActionResult GetPriceLowToHighMain()
        {
            List<Shoe> shoesList = dataContext.Shoes.OrderBy(shoe => shoe.Price).ToList();
            return View(shoesList);
        }

        public ActionResult GetPriceLowToHighNike()
        {
            List<Shoe> onlyNike = dataContext.Shoes.Where(shoe => shoe.Brand == "Nike").OrderBy(shoe => shoe.Price).ToList();
            return View(onlyNike);
        }

        public ActionResult GetPriceLowToHighAdidas()
        {
            List<Shoe> onlyAdidas = dataContext.Shoes.Where(shoe => shoe.Brand == "Adidas").OrderBy(shoe => shoe.Price).ToList();
            return View(onlyAdidas);
        }

        public ActionResult GetPriceLowToHighNB()
        {
            List<Shoe> onlyNB = dataContext.Shoes.Where(shoe => shoe.Brand == "New Balance").OrderBy(shoe => shoe.Price).ToList();
            return View(onlyNB);
        }







        public ActionResult GetOnlyNikeSales()
        {
            List<Shoe> nikeShoes = dataContext.Shoes.Where(shoe => shoe.Brand == "Nike" && shoe.IsInSale == true).ToList();
            return View(nikeShoes);
        }

        public ActionResult GetOnlyAdidasSales()
        {
            List<Shoe> adidasShoes = dataContext.Shoes.Where(shoe => shoe.Brand == "Adidas" && shoe.IsInSale == true).ToList();
            return View(adidasShoes);
        }

        public ActionResult GetOnlyNBSales()
        {
            List<Shoe> nbShoes = dataContext.Shoes.Where(shoe => shoe.Brand == "New Balance" && shoe.IsInSale == true).ToList();
            return View(nbShoes);
        }

        public ActionResult GetPriceHighToLowMainSales()
        {
            List<Shoe> shoesList = dataContext.Shoes.Where(shoe => shoe.IsInSale == true).OrderByDescending(shoe => shoe.Price).ToList();
            return View(shoesList);
        }

        public ActionResult GetPriceHighToLowNikeSales()
        {
            List<Shoe> onlyNike = dataContext.Shoes.Where(shoe => shoe.Brand == "Nike" && shoe.IsInSale == true).OrderByDescending(shoe => shoe.Price).ToList();
            return View(onlyNike);
        }

        public ActionResult GetPriceHighToLowAdidasSales()
        {
            List<Shoe> onlyAdidas = dataContext.Shoes.Where(shoe => shoe.Brand == "Adidas" && shoe.IsInSale == true).OrderByDescending(shoe => shoe.Price).ToList();
            return View(onlyAdidas);
        }

        public ActionResult GetPriceHighToLowNBSales()
        {
            List<Shoe> onlyNB = dataContext.Shoes.Where(shoe => shoe.Brand == "New Balance" && shoe.IsInSale == true).OrderByDescending(shoe => shoe.Price).ToList();
            return View(onlyNB);
        }

        public ActionResult GetPriceLowToHighMainSales()
        {
            List<Shoe> shoesList = dataContext.Shoes.Where(shoe => shoe.IsInSale == true).OrderBy(shoe => shoe.Price).ToList();
            return View(shoesList);
        }

        public ActionResult GetPriceLowToHighNikeSales()
        {
            List<Shoe> onlyNike = dataContext.Shoes.Where(shoe => shoe.Brand == "Nike" && shoe.IsInSale == true).OrderBy(shoe => shoe.Price).ToList();
            return View(onlyNike);
        }

        public ActionResult GetPriceLowToHighAdidasSales()
        {
            List<Shoe> onlyAdidas = dataContext.Shoes.Where(shoe => shoe.Brand == "Adidas" && shoe.IsInSale == true).OrderBy(shoe => shoe.Price).ToList();
            return View(onlyAdidas);
        }

        public ActionResult GetPriceLowToHighNBSales()
        {
            List<Shoe> onlyNB = dataContext.Shoes.Where(shoe => shoe.Brand == "New Balance" && shoe.IsInSale == true).OrderBy(shoe => shoe.Price).ToList();
            return View(onlyNB);
        }








        public ActionResult GetOnlyNikeAdmin()
        {
            List<Shoe> nikeShoes = dataContext.Shoes.Where(shoe => shoe.Brand == "Nike").ToList();
            return View(nikeShoes);
        }

        public ActionResult GetOnlyAdidasAdmin()
        {
            List<Shoe> adidasShoes = dataContext.Shoes.Where(shoe => shoe.Brand == "Adidas").ToList();
            return View(adidasShoes);
        }

        public ActionResult GetOnlyNBAdmin()
        {
            List<Shoe> nbShoes = dataContext.Shoes.Where(shoe => shoe.Brand == "New Balance").ToList();
            return View(nbShoes);
        }

        public ActionResult GetPriceHighToLowMainAdmin()
        {
            List<Shoe> shoesList = dataContext.Shoes.OrderByDescending(shoe => shoe.Price).ToList();
            return View(shoesList);
        }

        public ActionResult GetPriceHighToLowNikeAdmin()
        {
            List<Shoe> onlyNike = dataContext.Shoes.Where(shoe => shoe.Brand == "Nike").OrderByDescending(shoe => shoe.Price).ToList();
            return View(onlyNike);
        }

        public ActionResult GetPriceHighToLowAdidasAdmin()
        {
            List<Shoe> onlyAdidas = dataContext.Shoes.Where(shoe => shoe.Brand == "Adidas").OrderByDescending(shoe => shoe.Price).ToList();
            return View(onlyAdidas);
        }

        public ActionResult GetPriceHighToLowNBAdmin()
        {
            List<Shoe> onlyNB = dataContext.Shoes.Where(shoe => shoe.Brand == "New Balance").OrderByDescending(shoe => shoe.Price).ToList();
            return View(onlyNB);
        }

        public ActionResult GetPriceLowToHighMainAdmin()
        {
            List<Shoe> shoesList = dataContext.Shoes.OrderBy(shoe => shoe.Price).ToList();
            return View(shoesList);
        }

        public ActionResult GetPriceLowToHighNikeAdmin()
        {
            List<Shoe> onlyNike = dataContext.Shoes.Where(shoe => shoe.Brand == "Nike").OrderBy(shoe => shoe.Price).ToList();
            return View(onlyNike);
        }

        public ActionResult GetPriceLowToHighAdidasAdmin()
        {
            List<Shoe> onlyAdidas = dataContext.Shoes.Where(shoe => shoe.Brand == "Adidas").OrderBy(shoe => shoe.Price).ToList();
            return View(onlyAdidas);
        }

        public ActionResult GetPriceLowToHighNBAdmin()
        {
            List<Shoe> onlyNB = dataContext.Shoes.Where(shoe => shoe.Brand == "New Balance").OrderBy(shoe => shoe.Price).ToList();
            return View(onlyNB);
        }

    }
}