using System.Collections.Generic;
namespace VotingAPI.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}