using ContemporaryProgrammingFinal.Data;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinal.Controllers
{
    [ApiController]
    [Route("controller")]
    public class TeamMembersController : ControllerBase
    {
        private readonly ILogger<TeamMembersController> _logger;
        private readonly TeamInfoContext _context;
        public TeamMembersController(ILogger<TeamMembersController> logger, TeamInfoContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Members.ToList());
        }
    }
}
