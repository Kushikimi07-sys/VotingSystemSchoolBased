using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotingAPI.Data;
using VotingAPI.Models;
using System.Linq;

namespace VotingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VoteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VoteController(AppDbContext context)
        {
            _context = context;
        }

        //  SUBMIT VOTE
        [HttpPost]
        public IActionResult Vote(Vote v)
        {
            var already = _context.Votes
                .Any(x => x.UserId == v.UserId && x.PositionId == v.PositionId);

            if (already)
                return BadRequest("Already voted!");

            _context.Votes.Add(v);
            _context.SaveChanges();

            return Ok("Vote counted");
        }

        // 📊 RESULTS (ADD THIS)
      [HttpGet("results")]
public IActionResult Results()
{
    var result = _context.Positions
        .Select(p => new
        {
            position = p.Name,
            candidates = _context.Candidates
                .Where(c => c.PositionId == p.Id) // 🔥 IMPORTANT
                .Select(c => new
                {
                    name = c.Name,
                    teamName = _context.Teams
                        .Where(t => t.Id == c.TeamId)
                        .Select(t => t.Name)
                        .FirstOrDefault(),

                    votes = _context.Votes
                        .Count(v => v.CandidateId == c.Id)
                })
                .ToList()
        })
        .ToList();

    return Ok(result);
}
    }
}