namespace SmartOfficeAI.Entities
{
    public class Attachment : BaseEntity
    {
        public Guid? EmailMessageId { get; set; }
        public Guid? EmailDraftId { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public long FileSize { get; set; }

        public EmailMessage? EmailMessage { get; set; }
        public EmailDraft? EmailDraft { get; set; }
    }
}
