using SportShop_Program.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SportShop_Program.Controllers.api
{
    public class ClothingApiController : ApiController
    {
        SportShopContextDataContext dataContext = new SportShopContextDataContext();
        // GET: api/ClothingApi
        public IHttpActionResult Get()
        {
            try
            {
                List<Clothing> clothingList = dataContext.Clothings.ToList();
                return Ok(new { Massage = "Success", Clothing = clothingList });
            }
            catch (SqlException sqlGetEx)
            {
                return BadRequest(sqlGetEx.Message);
            }
            catch (Exception getEx)
            {
                return BadRequest(getEx.Message);
            }
        }

        // GET: api/ClothingApi/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(new { Massage = "Success", Clothing = dataContext.Clothings.First(item => item.Id == id) });
            }
            catch (SqlException sqlGetIdEx)
            {
                return BadRequest(sqlGetIdEx.Message);
            }
            catch (Exception getIdEx)
            {
                return BadRequest(getIdEx.Message);
            }
        }

        // POST: api/ClothingApi
        public IHttpActionResult Post([FromBody] Clothing newCloth)
        {
            try
            {
                dataContext.Clothings.InsertOnSubmit(newCloth);
                dataContext.SubmitChanges();
                return Ok(new { Massage = "Success, new cloth added" });
            }
            catch (SqlException sqlPostEx)
            {
                return BadRequest(sqlPostEx.Message);
            }
            catch (Exception getPostEx)
            {
                return BadRequest(getPostEx.Message);
            }
        }

        // PUT: api/ClothingApi/5
        public IHttpActionResult Put(int id, [FromBody] Clothing editedCloth)
        {
            try
            {
                Clothing expectedCloth = dataContext.Clothings.First(item => item.Id == id);
                expectedCloth.Brand = editedCloth.Brand;
                expectedCloth.ClothingType = editedCloth.ClothingType;
                expectedCloth.Gender = editedCloth.Gender;
                expectedCloth.ImgLink = editedCloth.ImgLink;
                expectedCloth.IsDrifit = editedCloth.IsDrifit;
                expectedCloth.IsShort = editedCloth.IsShort;
                expectedCloth.Model = editedCloth.Model;
                expectedCloth.Price = editedCloth.Price;
                expectedCloth.Quantity = editedCloth.Quantity;

                dataContext.SubmitChanges();

                return Ok(new { Massage = "Success, cloth edited" });


            }
            catch (SqlException sqlPutEx)
            {
                return BadRequest(sqlPutEx.Message);
            }
            catch (Exception getPutEx)
            {
                return BadRequest(getPutEx.Message);
            }
        }

        // DELETE: api/ClothingApi/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                dataContext.Clothings.DeleteOnSubmit(dataContext.Clothings.First(item => item.Id == id));

                dataContext.SubmitChanges();

                return Ok(new { Massage = "Success, cloth deleted" });
            }
            catch (SqlException sqlDelEx)
            {
                return BadRequest(sqlDelEx.Message);
            }
            catch (Exception getDelEx)
            {
                return BadRequest(getDelEx.Message);
            }
        }
    }
}
