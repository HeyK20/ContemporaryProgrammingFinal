using ContemporaryProgrammingFinal.Data;
using ContemporaryProgrammingFinal.Interfaces;
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
            if (member == null) 
            {
                return Ok(_context.GetFirstFive());
            }
            return Ok(_context.GetMember(id));
        }
    }
}
