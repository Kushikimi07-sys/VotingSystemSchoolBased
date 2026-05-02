namespace VotingAPI.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PositionId { get; set; }
        public int CandidateId { get; set; }
    }
}