
namespace SmartOfficeAI.Persistance.EntitiesConfigurations
{
    public class EmailTemplateConfigurations : IEntityTypeConfiguration<EmailTemplate>
    {
        public void Configure(EntityTypeBuilder<EmailTemplate> builder)
        {
            builder.ToTable("EmailTemplates");


            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(e => e.Content)
                .IsRequired()
                .HasColumnType("nvarchar(max)");
        }
    }
}
