
namespace SmartOfficeAI.Persistance.EntitiesConfigurations;

public class CandidateAnalysisConfigurations : IEntityTypeConfiguration<CandidateAnalysis>
{
    public void Configure(EntityTypeBuilder<CandidateAnalysis> builder)
    {
        builder.ToTable("CandidateAnalyses");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.AIConfidenceScore)
            .HasPrecision(5, 2);

        builder.Property(a => a.SkillMatchScore)
            .HasPrecision(5, 2);

        builder.Property(a => a.ExperienceMatchScore)
            .HasPrecision(5, 2);

        builder.Property(a => a.EducationMatchScore)
            .HasPrecision(5, 2);

        builder.Property(a => a.CertificationsMatchScore)
            .HasPrecision(5, 2);

        builder.Property(a => a.SuggestedRole)
            .HasMaxLength(200);

        builder.Property(a => a.KeySkillsExtracted)
            .HasMaxLength(2000);

        builder.Property(a => a.Notes)
            .HasMaxLength(2000);

        builder.Property(a => a.AnalyzedAt)
            .IsRequired();

        builder.HasOne(a => a.Candidate)
            .WithMany(c => c.Analyses)
            .HasForeignKey(a => a.CandidateId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(a => a.JobDescription)
            .WithMany()
            .HasForeignKey(a => a.JobDescriptionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
