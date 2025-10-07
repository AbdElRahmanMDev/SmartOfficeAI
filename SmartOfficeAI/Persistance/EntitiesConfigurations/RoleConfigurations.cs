namespace SmartOfficeAI.Persistance.EntitiesConfigurations
{
    public class RoleConfigurations : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.Description)
                .HasMaxLength(500);

            builder.HasMany(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict); // avoid deleting users when a role is deleted

            // ✅ Seed initial roles
            builder.HasData(
                new Role
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "Regular Employee",
                    Description = "موظف عادي - Access: Tabs 1-4, 6 (Email management + personal productivity)"
                },
                new Role
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Name = "HR / Talent Acquisition",
                    Description = "موارد بشرية - Access: Tabs 1-6 (Full platform: Email + CV screening & recruitment)"
                },
                new Role
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Name = "Administrative Communications Officer",
                    Description = "موظف الاتصالات الإدارية - Access: Tabs 1-4, 6, 7 (Document Processing)"
                },
                new Role
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    Name = "Admin",
                    Description = "مدير النظام - Full system access and management"
                }
            );
        }
    }
}
