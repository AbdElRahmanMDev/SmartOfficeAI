using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartOfficeAI.Entities
{
    public class Feature : BaseEntity
    {

        public string Name { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? Description { get; set; }


        public Guid TabId { get; set; }

        [ForeignKey(nameof(TabId))]
        public Tab Tab { get; set; } = default!;
    }
}
