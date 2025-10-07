using SmartOfficeAI.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace SmartOfficeAI.Entities
{
    public class Document : BaseEntity
    {

        public string DocumentNumber { get; set; }

        public DateTime DocumentDate { get; set; }

        public string Source { get; set; }
        public string Sender { get; set; }

        [MaxLength(300)]
        public string Subject { get; set; }

        [MaxLength(50)]
        public DocumentType DocumentType { get; set; }
    }
}
