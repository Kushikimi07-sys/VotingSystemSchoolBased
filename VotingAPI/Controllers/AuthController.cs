using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using VotingAPI.Data;
using VotingAPI.Models;
using System.Linq;

namespace VotingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        // ===== LOGIN =====
        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            if (user == null || string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
                return BadRequest("Invalid input");

            var u = _context.Users
                .FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);

            if (u == null)
                return Unauthorized();

            // 🔥 FIXED ROLE
            var role = string.IsNullOrEmpty(u.Role) ? "voter" : u.Role.ToLower().Trim();

            return Ok(new
            {
                id = u.Id,
                username = u.Username,
                role = role
            });
        }

        // ===== REGISTER =====
        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (user == null || string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
                return BadRequest("Invalid input");

            try
            {
                var newUser = new User
                {
                    Username = user.Username.Trim(),
                    Password = user.Password.Trim(),
                    Role = string.IsNullOrEmpty(user.Role) ? "voter" : user.Role.ToLower().Trim()
                };

                _context.Users.Add(newUser);
                _context.SaveChanges();

                return Ok(newUser);
            }
            catch (Exception ex)
            {
                Console.WriteLine("REGISTER ERROR: " + ex.Message);
                return StatusCode(500, "Server error");
            }
        }
    }
}