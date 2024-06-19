using Newtonsoft.Json;

namespace WebApi.Models
{
    public class CustomQuestionAnswer
    {
        [JsonProperty("Question")]
        public string Question { get; set; }
        [JsonProperty("Answer")]
        public string Answer { get; set; }
    }
}
