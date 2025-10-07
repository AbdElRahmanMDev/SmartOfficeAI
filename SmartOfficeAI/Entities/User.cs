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

        public RequestStatus status { get; set; } = RequestStatus.Pending;

        public Guid RoleId { get; set; }

        public Role Role { get; set; } = default!;

        public ICollection<EmailDraft> EmailDrafts { get; set; } = new List<EmailDraft>();

        public virtual ICollection<EmailMessage> SentMessages { get; set; } = new List<EmailMessage>();
        public virtual ICollection<EmailMessage> ReceivedMessages { get; set; } = new List<EmailMessage>();
    }
}
