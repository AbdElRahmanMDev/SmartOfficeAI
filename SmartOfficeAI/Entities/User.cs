using SmartOfficeAI.Entities.Common;

namespace SmartOfficeAI.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;

        public string Position { get; set; } = string.Empty;
        public string LanguageLanguagePreference { get; set; } = string.Empty;

        public Status status { get; set; } = Status.Pending;

        public Guid RoleId { get; set; }

        public Role Role { get; set; } = default!;

    }
}
