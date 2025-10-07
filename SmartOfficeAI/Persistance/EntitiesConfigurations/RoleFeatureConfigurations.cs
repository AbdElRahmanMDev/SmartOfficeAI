
namespace SmartOfficeAI.Persistance.EntitiesConfigurations
{
    public class RoleFeatureConfigurations : IEntityTypeConfiguration<RoleFeature>
    {
        public void Configure(EntityTypeBuilder<RoleFeature> builder)
        {
            builder.ToTable("RoleFeatures");

            builder.HasKey(rf => rf.Id);

            builder.Property(rf => rf.IsActive)
                .IsRequired();

            builder.HasOne(rf => rf.Role)
                .WithMany()
                .HasForeignKey(rf => rf.RoleId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(rf => rf.Feature)
                .WithMany()
                .HasForeignKey(rf => rf.FeatureId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(rf => new { rf.RoleId, rf.FeatureId })
                .IsUnique(); // each role-feature pair should be unique
        }
    }
}
