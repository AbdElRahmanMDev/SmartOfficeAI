namespace SmartOfficeAI.Persistance.EntitiesConfigurations
{
    public class DocumentConfigurations : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.Property(d => d.DocumentNumber)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(d => d.DocumentDate)
                .IsRequired();

            builder.Property(d => d.Source)
                .HasMaxLength(200);

            builder.Property(d => d.Sender)
                .HasMaxLength(200);

            builder.Property(d => d.Subject)
                .HasMaxLength(300)
                .IsRequired();

            builder.HasIndex(d => d.DocumentNumber)
                .IsUnique();
        }
    }
}
