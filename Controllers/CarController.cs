using ContemporaryProgrammingFinal.Data;
using ContemporaryProgrammingFinal.Interfaces;
using ContemporaryProgrammingFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinal.Controllers
{
    [ApiController]
    [Route("car")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarContextDAO _context;
        public CarController(ILogger<CarController> logger, ICarContextDAO context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllCars());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var currentCar = _context.GetCar(id);
            if (currentCar == null)
            {
                return Ok(_context.GetFirstFive());
            }
            return Ok(_context.GetCar(id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveCar(id);
            if (result == null)
            {
                return NotFound();
            }
            if (result == 0)
            {
                return StatusCode(500, "An error has occured");
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(Car currentCar)
        {
            var result = _context.UpdateCar(currentCar);

            if (result == null)
            {
                return NotFound(currentCar.Id);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error has occured");
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(Car currentCar)
        {
            var result = _context.AddCar(currentCar);

            if (result == null)
            {
                return StatusCode(500, "Car already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error has occured");
            }
            return Ok();
        }

    }
}
