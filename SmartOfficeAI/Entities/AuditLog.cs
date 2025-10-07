using System.ComponentModel.DataAnnotations.Schema;

namespace SmartOfficeAI.Entities
{
    public class AuditLog : BaseEntity
    {
        public string ActionType { get; set; }

        public string Description { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        public string UserEmail { get; set; }

        public Guid? CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
