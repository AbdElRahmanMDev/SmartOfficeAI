namespace SmartOfficeAI.Entities
{
    public class Tab : BaseEntity
    {
        public string TabNameEN { get; set; } = string.Empty;
        public string TabNameAR { get; set; } = string.Empty;

        public string TabDescription { get; set; } = string.Empty;

        public string VisibleTo { get; set; } = string.Empty;

        public string Purpose { get; set; } = string.Empty;

        public ICollection<Feature> Features { get; set; } = new List<Feature>();

    }
}
