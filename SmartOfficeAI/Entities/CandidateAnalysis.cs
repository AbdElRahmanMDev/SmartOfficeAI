namespace SmartOfficeAI.Entities
{
    public class CandidateAnalysis : BaseEntity
    {
        public Guid CandidateId { get; set; }
        public Candidate Candidate { get; set; } = default!;

        public Guid? JobDescriptionId { get; set; }

        public JobDescription? JobDescription { get; set; }

        public decimal AIConfidenceScore { get; set; }
        public decimal SkillMatchScore { get; set; }
        public decimal ExperienceMatchScore { get; set; }
        public decimal EducationMatchScore { get; set; }
        public decimal CertificationsMatchScore { get; set; }
        public string SuggestedRole { get; set; }
        public string KeySkillsExtracted { get; set; }
        public string Notes { get; set; }
        public DateTime AnalyzedAt { get; set; }


    }
}
