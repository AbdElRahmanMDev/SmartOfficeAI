namespace SmartOfficeAI.Entities
{
    public class EmailClassification : BaseEntity
    {
        public string Name { get; set; } = string.Empty; // Urgent, Follow-up, FYI, Spam
        public string Description { get; set; } = string.Empty;

        public ICollection<EmailMessage> EmailMessages { get; set; } = new List<EmailMessage>();

    }
}
