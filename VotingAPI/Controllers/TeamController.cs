using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotingAPI.Data;
using VotingAPI.Models;
using System.Linq;

namespace VotingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_context.Teams.ToList());

        [HttpPost]
        public IActionResult Add(Team t)
        {
            // ✅ ADMIN CHECK REMOVED (for testing)

            _context.Teams.Add(t);
            _context.SaveChanges();

            return Ok(t);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // ✅ ADMIN CHECK REMOVED

            var team = _context.Teams.Find(id);

            if (team == null)
                return NotFound();

            _context.Teams.Remove(team);
            _context.SaveChanges();

            return Ok("Deleted");
        }
    }
}