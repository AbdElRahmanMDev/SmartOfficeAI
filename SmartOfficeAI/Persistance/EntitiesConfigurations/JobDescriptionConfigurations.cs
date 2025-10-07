
namespace SmartOfficeAI.Persistance.EntitiesConfigurations
{
    public class JobDescriptionConfigurations : IEntityTypeConfiguration<JobDescription>
    {
        public void Configure(EntityTypeBuilder<JobDescription> builder)
        {
            builder.ToTable("JobDescriptions");
            builder.Property(j => j.Description)
               .HasColumnType("nvarchar(max)");

            builder.Property(j => j.RequiredSkills)
                .HasMaxLength(1000);

            builder.Property(j => j.ExperienceRequired)
                .IsRequired();

            builder.Property(j => j.EducationRequired)
                .HasMaxLength(200);

            builder.Property(j => j.CertificationsRequired)
                .HasMaxLength(500);

            builder.Property(j => j.CreatedDate)
                .IsRequired();

            builder.Property(j => j.jobStatus)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.HasMany(j => j.Analyses)
                .WithOne(a => a.JobDescription)
                .HasForeignKey(a => a.JobDescriptionId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
