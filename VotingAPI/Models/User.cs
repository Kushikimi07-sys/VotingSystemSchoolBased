using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; } = "";

        public string Password { get; set; } = "";

        [Column("role")] // 🔥 FIX for MySQL
        public string Role { get; set; } = "";
    }
}