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
    public class GearApiController : ApiController
    {
        SportShopContextDataContext dataContext = new SportShopContextDataContext();
        // GET: api/GearApi
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(new { Massage = "Success", Gear = dataContext.Gears.ToList() });
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

        // GET: api/GearApi/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(new { Massage = "Success", Gear = dataContext.Gears.First(item => item.Id == id) });
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

        // POST: api/GearApi
        public IHttpActionResult Post([FromBody] Gear newGear)
        {
            try
            {
                dataContext.Gears.InsertOnSubmit(newGear);
                dataContext.SubmitChanges();
                return Ok(new { Massage = "Success, new gear added" });
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

        // PUT: api/GearApi/5
        public IHttpActionResult Put(int id, [FromBody] Gear editedGear)
        {
            try
            {
                Gear expectedGear = dataContext.Gears.First(item => item.Id == id);

                expectedGear.Brand = editedGear.Brand;
                expectedGear.ImgLink = editedGear.ImgLink;
                expectedGear.Price = editedGear.Price;
                expectedGear.ProductName = editedGear.ProductName;
                expectedGear.Quantity = editedGear.Quantity;
                expectedGear.SportType = editedGear.SportType;

                dataContext.SubmitChanges();

                return Ok(new { Massage = "Success, gear edited" });


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

        // DELETE: api/GearApi/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                dataContext.Gears.DeleteOnSubmit(dataContext.Gears.First(item => item.Id == id));

                dataContext.SubmitChanges();

                return Ok(new { Massage = "Success, gear deleted" });
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
