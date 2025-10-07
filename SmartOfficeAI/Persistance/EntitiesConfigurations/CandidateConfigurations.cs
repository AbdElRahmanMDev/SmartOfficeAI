
namespace SmartOfficeAI.Persistance.EntitiesConfigurations
{
    public class CandidateConfigurations : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.ToTable("Candidates");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.FullName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Phone)
                .HasMaxLength(20);

            builder.Property(c => c.CurrentPosition)
                .HasMaxLength(150);

            builder.Property(c => c.Skills)
                .HasMaxLength(1000);

            builder.Property(c => c.EducationLevel)
                .HasMaxLength(150);

            builder.Property(c => c.Certifications)
                .HasMaxLength(1000);

            builder.Property(c => c.Languages)
                .HasMaxLength(500);

            builder.Property(c => c.CVFilePath)
                .HasMaxLength(500);

            builder.HasMany(c => c.Analyses)
                .WithOne(a => a.Candidate)
                .HasForeignKey(a => a.CandidateId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
