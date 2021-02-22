using System.Collections.Generic;
using KraigsList.Models;
using KraigsList.Services;
using Microsoft.AspNetCore.Mvc;


namespace KraigsList.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class HousesController : ControllerBase
    {

        private readonly HousesService _hs;
        public HousesController(HousesService hs)
        {
            _hs = hs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<House>> Get()
        {
            try
            {
                return Ok(_hs.Get());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);


            }
        }

        [HttpGet("{id}")]
        public ActionResult<House> GetHouseById(string id)
        {
            try
            {
                House House = _hs.GetHouseById(id);
                return Ok(House);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<House> Create([FromBody] House newHouse)
        {
            try
            {
                House house = _hs.Create(newHouse);
                return Ok(house);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<House> Edit([FromBody] House updated, string id)
        {
            try
            {
                updated.Id = id;
                House House = _hs.Edit(updated);
                return Ok(House);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
        [HttpDelete("{HouseId}")]
        public ActionResult<string> Purchased(string HouseId)
        {
            try
            {
                _hs.Delete(HouseId);
                return Ok("Deleted");
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}