namespace SmartOfficeAI.Entities
{
    public class Candidate : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string CurrentPosition { get; set; }
        public string Skills { get; set; }
        public int ExperienceYears { get; set; }
        public string EducationLevel { get; set; }
        public string Certifications { get; set; }
        public string Languages { get; set; }
        public string CVFilePath { get; set; }

        public Guid JobDescriptionId { get; set; }
        public JobDescription JobDescription { get; set; }
        public ICollection<CandidateAnalysis> Analyses { get; set; } = [];

    }
}
