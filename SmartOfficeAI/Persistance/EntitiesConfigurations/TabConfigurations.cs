
namespace SmartOfficeAI.Persistance.EntitiesConfigurations
{
    public class TabConfigurations : IEntityTypeConfiguration<Tab>
    {
        public void Configure(EntityTypeBuilder<Tab> builder)
        {
            builder.ToTable("Tabs");


            builder.Property(t => t.TabNameEN)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(t => t.TabNameAR)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(t => t.TabDescription)
                   .HasMaxLength(500);

            builder.Property(t => t.VisibleTo)
                   .HasMaxLength(100);

            builder.Property(t => t.Purpose)
                   .HasMaxLength(250);

            builder.HasMany(t => t.Features)
                   .WithOne(f => f.Tab)
                   .HasForeignKey(f => f.TabId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
