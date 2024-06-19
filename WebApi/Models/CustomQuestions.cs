using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

using WebApi.Models.Dto;
using WebApi.Models.Enums;

namespace WebApi.Models
{
    public class CustomQuestions
    {
        [JsonProperty("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString(); 
        [JsonProperty("QuestionType")]
        public QuestionType QuestionType { get; set; }
        [JsonProperty("Question")]
        public string Question { get; set; }
        [JsonProperty("DropDownChoice")]
        public MultipleChoiceQuestionDTO? DropdownChoice { get; set; }
    }
}
