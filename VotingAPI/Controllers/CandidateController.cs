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
        public IActionResult Get() => Ok(_context.Candidates.ToList());

        [HttpPost]
public IActionResult Add([FromBody] Candidate c)
{
    // 🔥 IGNORE VALIDATION ERRORS
    ModelState.Clear();

    if (string.IsNullOrWhiteSpace(c.Name))
        return BadRequest("Name required");

    _context.Candidates.Add(c);
    _context.SaveChanges();

    return Ok(c);
}
    }
}