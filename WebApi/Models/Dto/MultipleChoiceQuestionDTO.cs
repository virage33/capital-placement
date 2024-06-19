namespace WebApi.Models.Dto
{
    public class MultipleChoiceQuestionDTO
    {
        public List<string>? Choice { get; set; }
        public bool EnableOther { get;set; }
        public int MaxChoice { get; set; }
        public bool IsMultiChoice { get; set; }
    }
}
