using ContemporaryProgrammingFinal.Data;
using ContemporaryProgrammingFinal.Interfaces;
using ContemporaryProgrammingFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinal.Controllers
{
    [ApiController]
    [Route("teammembers")]
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
        [HttpGet("name")]
        public IActionResult Get(string name)
        {
            var member = _context.GetMember(name);
            if (member == null)
            {
                return Ok(_context.GetFirstFive());
            }
            return Ok(_context.GetMember(name));
        }

        [HttpDelete]
        public IActionResult Delete(string name)
        {
            var result = _context.RemoveMember(name);
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
        public IActionResult Put(Breakfast member)
        {
            var result = _context.UpdateMember(member);

            if (result == null)
            {
                return NotFound(member.Name);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error has occured");
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(Breakfast member)
        {
            var result = _context.AddMember(member);

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
