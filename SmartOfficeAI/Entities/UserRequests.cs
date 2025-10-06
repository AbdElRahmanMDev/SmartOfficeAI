using SmartOfficeAI.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartOfficeAI.Entities
{
    public class UserRequests : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = default!;

        public Guid RequestedRoleId { get; set; }
        [ForeignKey(nameof(RequestedRoleId))]

        public Role RequestedRole { get; set; } = default!;

        public Status Status { get; set; } = Status.Pending;

        public Guid? ReviewedById { get; set; }  // Admin UserId

        [ForeignKey(nameof(ReviewedById))]
        public User? ReviewedByUser { get; set; }

        public DateTime? ReviewedAt { get; set; }
    }
}
