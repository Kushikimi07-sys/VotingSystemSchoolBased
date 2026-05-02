using System.Text.Json.Serialization;

namespace VotingAPI.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int TeamId { get; set; }

        [JsonIgnore]
        public Team? Team { get; set; }

        public int PositionId { get; set; }

        [JsonIgnore]
        public Position? Position { get; set; }
    }
}