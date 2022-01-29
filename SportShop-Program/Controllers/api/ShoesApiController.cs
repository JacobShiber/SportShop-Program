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
    public class ShoesApiController : ApiController
    {
        SportShopContextDataContext dataContext = new SportShopContextDataContext();
        // GET: api/ShoesApi
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(new { Massage = "Success", Shoes = dataContext.Shoes.ToList() });
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

        // GET: api/ShoesApi/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(new { Massage = "Success", Shoe = dataContext.Shoes.First(item => item.Id == id) });
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

        // POST: api/ShoesApi
        public IHttpActionResult Post([FromBody] Shoe newShoe)
        {
            try
            {
                dataContext.Shoes.InsertOnSubmit(newShoe);
                dataContext.SubmitChanges();
                return Ok(new { Massage = "Success, new shoe added" });
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

        // PUT: api/ShoesApi/5
        public IHttpActionResult Put(int id, [FromBody]Shoe editedShoe)
        {
            try
            {
                Shoe expectedShoe = dataContext.Shoes.First(item => item.Id == id);

                expectedShoe.Brand = editedShoe.Brand;
                expectedShoe.ImgLink = editedShoe.ImgLink;
                expectedShoe.IsInSale = editedShoe.IsInSale;
                expectedShoe.Price = editedShoe.Price;
                expectedShoe.Quantity = editedShoe.Quantity;
                expectedShoe.ShoeModel = editedShoe.ShoeModel;
                expectedShoe.ShoeType = editedShoe.ShoeType;

                dataContext.SubmitChanges();

                return Ok(new { Massage = "Success, shoe edited" });
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

        // DELETE: api/ShoesApi/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                dataContext.Shoes.DeleteOnSubmit(dataContext.Shoes.First(item => item.Id == id));

                dataContext.SubmitChanges();

                return Ok(new { Massage = "Success, shoe deleted" });
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
