using System.ComponentModel.DataAnnotations.Schema;

namespace SmartOfficeAI.Entities
{
    public class RoleFeature : BaseEntity
    {

        public Guid RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; } = default!;

        public Guid FeatureId { get; set; }

        [ForeignKey(nameof(FeatureId))]
        public Feature Feature { get; set; } = default!;

        public bool IsActive { get; set; }

    }
}
