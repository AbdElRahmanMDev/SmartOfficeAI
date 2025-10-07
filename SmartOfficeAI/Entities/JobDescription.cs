using SmartOfficeAI.Entities.Common;

namespace SmartOfficeAI.Entities
{
    public class JobDescription : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string RequiredSkills { get; set; }
        public int ExperienceRequired { get; set; }
        public string EducationRequired { get; set; }
        public string CertificationsRequired { get; set; }
        public DateTime CreatedDate { get; set; }
        public JobStatus jobStatus { get; set; }

        public ICollection<CandidateAnalysis> Analyses { get; set; }
    }
}
