using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotingAPI.Data;
using VotingAPI.Models;
using System.Linq;

namespace VotingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidateController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CandidateController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
public IActionResult Get()
{
    var data = _context.Candidates
        .Include(c => c.Position)
        .Select(c => new
        {
            id = c.Id,
            name = c.Name,
            teamId = c.TeamId,
            positionId = c.PositionId,
            positionName = c.Position.Name
        })
        .ToList();

    return Ok(data);
}

        [HttpPost]
public IActionResult Add([FromBody] Candidate c)
{
    //  IGNORE VALIDATION ERRORS
    ModelState.Clear();

    if (string.IsNullOrWhiteSpace(c.Name))
        return BadRequest("Name required");

    _context.Candidates.Add(c);
    _context.SaveChanges();

    return Ok(c);
}

[HttpPut("{id}")]
public IActionResult Update(int id, Candidate c)
{
    if (id != c.Id)
        return BadRequest();

    var existing = _context.Candidates.Find(id);
    if (existing == null)
        return NotFound();

    existing.Name = c.Name;
    existing.TeamId = c.TeamId;
    existing.PositionId = c.PositionId;

    _context.SaveChanges();

    return Ok(existing);
}

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    var c = _context.Candidates.Find(id);
    if (c == null)
        return NotFound();

    _context.Candidates.Remove(c);
    _context.SaveChanges();

    return Ok("Deleted");
}

    }
}