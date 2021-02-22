
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using KraigsList.db;
using KraigsList.Models;
using KraigsList.Services;

namespace KraigsList.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class CarsController : ControllerBase
    {

        private readonly CarsService _cs;
        public CarsController(CarsService cs)
        {
            _cs = cs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAction()
        {
            try
            {
                return Ok(_cs.Get());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);


            }
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(string id)
        {
            try
            {
                Car car = _cs.GetCarById(id);
                return Ok(car);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car newCar)
        {
            try
            {
                Car car = _cs.Create(newCar);
                return Ok(car);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Car> Edit([FromBody] Car updated, string id)
        {
            try
            {
                updated.Id = id;
                Car car = _cs.Edit(updated);
                return Ok(car);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
        [HttpDelete("{carId}")]
        public ActionResult<string> Demolish(string carId)
        {
            try
            {
                _cs.Delete(carId);
                return Ok("Deleted");
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}