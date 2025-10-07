namespace SmartOfficeAI.Entities
{
    public class EmailMessage : BaseEntity
    {

        public Guid? FromUserId { get; set; }


        public string FromEmail { get; set; } = string.Empty;

        public Guid? ToUserId { get; set; }

        public string ToEmail { get; set; } = string.Empty;

        public string? Subject { get; set; }

        public string? Body { get; set; }

        public Guid? EmailClassificationId { get; set; }
        public EmailClassification? EmailClassification { get; set; }

        public User? FromUser { get; set; }
        public User? ToUser { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();


    }
}
