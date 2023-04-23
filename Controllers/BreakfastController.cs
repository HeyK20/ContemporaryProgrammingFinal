using ContemporaryProgrammingFinal.Data;
using ContemporaryProgrammingFinal.Interfaces;
using ContemporaryProgrammingFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinal.Controllers
{
    [ApiController]
    [Route("breakfast")]
    public class BreakfastController : ControllerBase
    {
        private readonly ILogger<BreakfastController> _logger;
        private readonly IBreakfastDAO _context;
        public BreakfastController(ILogger<BreakfastController> logger, IBreakfastDAO context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllMembers());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var member = _context.GetMember(id);
            if(id == 0)
            {
                return Ok(_context.GetFirstFive());
            }
            if (member == null)
            {
                return NotFound();
            }
            return Ok(_context.GetMember(id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveMember(id);
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
        public IActionResult Put(Breakfast id)
        {
            var result = _context.UpdateMember(id);

            if (result == null)
            {
                return NotFound(id.Name);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error has occured");
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(Breakfast id)
        {
            var result = _context.AddMember(id);

            if (result == null)
            {
                return StatusCode(500, "Member already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error has occured");
            }
            return Ok();
        }

    }
}
