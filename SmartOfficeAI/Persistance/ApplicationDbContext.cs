using System.Reflection;

namespace SmartOfficeAI.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }


        public DbSet<User> Users { get; set; }

        public DbSet<EmailMessage> EmailMessages { get; set; }

        public DbSet<Document> Documents { get; set; }

        public DbSet<DocumentAIAnalysis> DocumentAIAnalyses { get; set; }

        public DbSet<EmailTemplate> EmailTemplates { get; set; }



        public DbSet<Role> Roles { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<EmailDraft> EmailDrafts { get; set; }

        public DbSet<RoleFeature> RoleFeatures { get; set; }

        public DbSet<Tab> Tabs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

    }
}
