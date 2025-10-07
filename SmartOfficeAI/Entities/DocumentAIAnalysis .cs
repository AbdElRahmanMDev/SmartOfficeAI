using System.ComponentModel.DataAnnotations.Schema;

namespace SmartOfficeAI.Entities
{
    public class DocumentAIAnalysis : BaseEntity
    {
        public string SuggestedAction { get; set; }

        public string AIClassification { get; set; }

        public double ConfidenceScore { get; set; }

        [ForeignKey("Document")]
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

    }
}
