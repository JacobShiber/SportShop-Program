using SportShop_Program.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportShop_Program.Controllers.api
{
    public class ShirtsApiController : ApiController
    {
        SportShopContextDataContext dataContext = new SportShopContextDataContext();
        // GET: api/ShirtsApi
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(new { Massage = "Success", Shirts = dataContext.Clothings.Where(item => item.ClothingType == "Shirts").ToList() });
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

        // GET: api/ShirtsApi/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(new { Massage = "Success", Shirt = dataContext.Clothings.Where(item => item.ClothingType == "Shirts").First(item => item.Id == id) });
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

        // POST: api/ShirtsApi
        public IHttpActionResult Post([FromBody] Clothing newShirt)
        {
            try
            {
                if (newShirt.ClothingType == "Shirts")
                {
                    dataContext.Clothings.InsertOnSubmit(newShirt);
                    dataContext.SubmitChanges();
                    return Ok(new { Massage = "Success, new shirt added" });
                }
                else return BadRequest("Add only Shirts!");
                
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

        // PUT: api/ShirtsApi/5
        public IHttpActionResult Put(int id, [FromBody] Clothing editedShirt)
        {
            try
            {
                Clothing expectedShirt = dataContext.Clothings.First(item => item.Id == id);
                if (expectedShirt.ClothingType == "Shirts")
                {
                    expectedShirt.Brand = editedShirt.Brand;
                    expectedShirt.Gender = editedShirt.Gender;
                    expectedShirt.ImgLink = editedShirt.ImgLink;
                    expectedShirt.IsDrifit = editedShirt.IsDrifit;
                    expectedShirt.IsShort = editedShirt.IsShort;
                    expectedShirt.Model = editedShirt.Model;
                    expectedShirt.Price = editedShirt.Price;
                    expectedShirt.Quantity = editedShirt.Quantity;

                    dataContext.SubmitChanges();

                    return Ok(new { Massage = "Success, shirt edited" });
                }
                else return BadRequest("Only Shirts!");
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

        // DELETE: api/ShirtsApi/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                dataContext.Clothings.DeleteOnSubmit(dataContext.Clothings.Where(item => item.ClothingType == "Shirts").First(item => item.Id == id));

                dataContext.SubmitChanges();

                return Ok(new { Massage = "Success, shirt deleted" });
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
