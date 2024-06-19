using System.ComponentModel;

namespace WebApi.Models.Enums
{
    public enum QuestionType
    {
        [Description("Paragraph")]
        Paragraph,
        [Description("Yes/No")]
        YesOrNo,
        [Description("Dropdown")]
        Dropdown,
        [Description("Multiple Choice")]
        MultipleChoice,
        [Description("Date")]
        Date,
        [Description("Number")]
        Number
        
    }
}
