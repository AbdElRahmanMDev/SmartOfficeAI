
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

            builder.HasData(
                    new Tab
                    {
                        Id = Guid.Parse("cbdc2d0f-0d5e-4f1c-9b89-1a9d6c2a3e41"),
                        TabNameEN = "Profile",
                        TabNameAR = "الملف الشخصي",
                        VisibleTo = "All users",
                        Purpose = "User persona & preferences"
                    },
                    new Tab
                    {
                        Id = Guid.Parse("6f67e59c-04b5-4584-8a6d-b8cb3ac92f29"),
                        TabNameEN = "Inbox",
                        TabNameAR = "صندوق الوارد",
                        VisibleTo = "All users",
                        Purpose = "Smart email management"
                    },
                    new Tab
                    {
                        Id = Guid.Parse("e3b6d8a2-faf8-4c82-912f-4420b4cf29a3"),
                        TabNameEN = "Playground",
                        TabNameAR = "مساحة العمل",
                        VisibleTo = "All users",
                        Purpose = "Draft, analyze, rephrase emails"
                    },
                    new Tab
                    {
                        Id = Guid.Parse("23db5a92-63f0-4f42-b5e0-64e6b1a52e6f"),
                        TabNameEN = "Attachments",
                        TabNameAR = "المرفقات والأرشفة",
                        VisibleTo = "All users",
                        Purpose = "AI-powered file management"
                    },
                    new Tab
                    {
                        Id = Guid.Parse("ff4978e1-dc02-4cc0-bb27-8783c5a6a1c1"),
                        TabNameEN = "Talent Database",
                        TabNameAR = "قاعدة المواهب",
                        VisibleTo = "HR only",
                        Purpose = "CV screening & candidate ranking"
                    },
                    new Tab
                    {
                        Id = Guid.Parse("6c0e4a4b-1cf8-4626-9358-4cf0ee1a5a36"),
                        TabNameEN = "Analytics & Reports",
                        TabNameAR = "التقارير والإحصائيات",
                        VisibleTo = "All users (role-specific)",
                        Purpose = "Performance metrics & insights"
                    },
                    new Tab
                    {
                        Id = Guid.Parse("1d8239c9-76a4-4f73-a49e-087799cfd506"),
                        TabNameEN = "Document Workflow",
                        TabNameAR = "إدارة المعاملات",
                        VisibleTo = "Admin Comms only",
                        Purpose = "Official correspondence automation"
                    }
                );
        }
    }
}
