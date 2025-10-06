using System.ComponentModel;

namespace SmartOfficeAI.Common.Enums
{
    public enum ErrorCode
    {
        [Description("Unknown error")]
        Unknown = 0,

        [Description("Validation errors")]
        ValidationErrors = 1
    }
}
