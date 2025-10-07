namespace SmartOfficeAI.Entities
{
    public class EmailDraft : BaseEntity
    {
        public Guid CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; } = default!;

        public string ToEmail { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public DateTime LastModifiedDate { get; set; }

        public ICollection<Attachment> Attachments { get; set; } = [];
    }
}
