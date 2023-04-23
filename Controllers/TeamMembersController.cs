using ContemporaryProgrammingFinal.Data;
using ContemporaryProgrammingFinal.Interfaces;
using ContemporaryProgrammingFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinal.Controllers
{
    [ApiController]
    [Route("teammembers")]
    public class TeamMembersController : ControllerBase
    {
        private readonly ILogger<TeamMembersController> _logger;
        private readonly ITeamMembersContextDAO _context;
        public TeamMembersController(ILogger<TeamMembersController> logger, ITeamMembersContextDAO context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllMembers());
        }
        [HttpGet ("id")]
        public IActionResult Get(int id) 
        {
            var member= _context.GetMember(id);

            if (id == 0)
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
        public IActionResult Put(TeamInfo member)
        {
            var result = _context.UpdateMember(member);

            if (result == null)
            {
                return NotFound(member.Id);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error has occured");
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(TeamInfo member)
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
