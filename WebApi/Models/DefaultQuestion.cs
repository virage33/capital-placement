using Newtonsoft.Json;
using WebApi.Models.Enums;

namespace WebApi.Models
{
    public class DefaultQuestion
    {
       
        [JsonProperty("Title")]
        public string Title {  get; set; }
        [JsonProperty("QuestionType")]
        public QuestionType QuestionType { get; set; }
        [JsonProperty("isInternal")]
        public bool IsInternal { get; set; } = false;
        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }
        [JsonProperty("isMandatory")]
        public bool IsMandatory { get; set; }

    }
}
