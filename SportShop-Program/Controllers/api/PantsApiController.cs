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
    public class PantsApiController : ApiController
    {
        SportShopContextDataContext dataContext = new SportShopContextDataContext();
        // GET: api/PantsApi
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(new { Massage = "Success", Clothing = dataContext.Clothings.Where(item => item.ClothingType == "Pants").ToList() });
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

        // GET: api/PantsApi/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(new { Massage = "Success", Pants = dataContext.Clothings.Where(item => item.ClothingType == "Pants").First(item => item.Id == id) });
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

        // POST: api/PantsApi
        public IHttpActionResult Post([FromBody] Clothing newPants)
        {
            try
            {
                if (newPants.ClothingType == "Pants")
                {
                    dataContext.Clothings.InsertOnSubmit(newPants);
                    dataContext.SubmitChanges();
                    return Ok(new { Massage = "Success, new pants added" });
                }
                else return BadRequest("Add only Pants!");

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

        // PUT: api/PantsApi/5
        public IHttpActionResult Put(int id, [FromBody] Clothing editedPants)
        {
            try
            {
                Clothing expectedPants = dataContext.Clothings.First(item => item.Id == id);
                if (expectedPants.ClothingType == "Pants")
                {
                    expectedPants.Brand = editedPants.Brand;
                    expectedPants.Gender = editedPants.Gender;
                    expectedPants.ImgLink = editedPants.ImgLink;
                    expectedPants.IsDrifit = editedPants.IsDrifit;
                    expectedPants.IsShort = editedPants.IsShort;
                    expectedPants.Model = editedPants.Model;
                    expectedPants.Price = editedPants.Price;
                    expectedPants.Quantity = editedPants.Quantity;

                    dataContext.SubmitChanges();

                    return Ok(new { Massage = "Success, pants edited" });
                }

                else return BadRequest("Pick only pants!");

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

        // DELETE: api/PantsApi/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                dataContext.Clothings.DeleteOnSubmit(dataContext.Clothings.Where(item => item.ClothingType == "Pants").First(item => item.Id == id));

                dataContext.SubmitChanges();

                return Ok(new { Massage = "Success, pants deleted" });
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
