namespace SmartOfficeAI.Persistance.EntitiesConfigurations
{
    public class EmailMessageConfigurations : IEntityTypeConfiguration<EmailMessage>
    {
        public void Configure(EntityTypeBuilder<EmailMessage> builder)
        {
            builder.ToTable("EmailMessages");


            builder.Property(e => e.FromEmail)
               .IsRequired()
               .HasMaxLength(200);

            builder.Property(e => e.ToEmail)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Subject)
                .HasMaxLength(300);

            builder.HasOne(e => e.FromUser)
            .WithMany(u => u.SentMessages)
            .HasForeignKey(e => e.FromUserId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.ToUser)
                .WithMany(u => u.ReceivedMessages)
                .HasForeignKey(e => e.ToUserId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasMany(e => e.Attachments)
                .WithOne(a => a.EmailMessage)
                .HasForeignKey(a => a.EmailMessageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(e => e.FromEmail);
            builder.HasIndex(e => e.ToEmail);

        }
    }
}
