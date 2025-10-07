namespace SmartOfficeAI.Persistance.EntitiesConfigurations
{
    public class EmailDraftConfigurations : IEntityTypeConfiguration<EmailDraft>
    {
        public void Configure(EntityTypeBuilder<EmailDraft> builder)
        {
            builder.ToTable("EmailDrafts");



            builder.Property(e => e.ToEmail)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Subject)
                .HasMaxLength(300);

            builder.Property(e => e.Body)
                .HasColumnType("nvarchar(max)");

            builder.Property(e => e.LastModifiedDate)
                .IsRequired();

            builder.HasOne(e => e.CreatedByUser)
                .WithMany(u => u.EmailDrafts)
                .HasForeignKey(e => e.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.Attachments)
                .WithOne(a => a.EmailDraft)
                .HasForeignKey(a => a.EmailDraftId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
