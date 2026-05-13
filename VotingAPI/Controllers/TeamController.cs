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
    var team = _context.Teams.Find(id);

    if (team == null)
        return NotFound();

    //  DELETE RELATED CANDIDATES FIRST
    var candidates = _context.Candidates
        .Where(c => c.TeamId == id)
        .ToList();

    _context.Candidates.RemoveRange(candidates);

    //  DELETE TEAM
    _context.Teams.Remove(team);

    _context.SaveChanges();

    return Ok("Deleted");
}

        [HttpPut("{id}")]
public IActionResult Update(int id, Team t)
{
    if (id != t.Id)
        return BadRequest();

    var existing = _context.Teams.Find(id);
    if (existing == null)
        return NotFound();

    existing.Name = t.Name;

    _context.SaveChanges();

    return Ok(existing);
}

    }

}