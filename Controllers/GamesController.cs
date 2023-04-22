using ContemporaryProgrammingFinal.Data;
using ContemporaryProgrammingFinal.Interfaces;
using ContemporaryProgrammingFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinal.Controllers
{
    [ApiController]
    [Route("games")]
    public class GamesController : ControllerBase
    {
        private readonly ILogger<GamesController> _logger;
        private readonly IGamesContextDAO _context;
        public GamesController(ILogger<GamesController> logger, IGamesContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllGames());
        }

        [HttpGet ("id")]
        public IActionResult Get(int id) 
        {
            var game = _context.GetGame(id);
            if (id == 0)
            {
                return Ok(_context.GetFirstFive());
            }
            if (game == null) 
            {
                return NotFound();
            }
            return Ok(_context.GetGame(id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveGame(id);
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
        public IActionResult Put(Game game)
        {
            var result = _context.UpdateGame(game);

            if (result == null)
            {
                return NotFound(game.Id);
            }
            if (result == 0)
            {
                return StatusCode(500, "An error has occured");
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Game game)
        {
            var result = _context.AddGame(game);

            if (result == null)
            {
                return StatusCode(500, "Game already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error has occured");
            }
            return Ok();
        }

    }
}
