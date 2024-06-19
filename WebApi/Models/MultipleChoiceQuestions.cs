using Newtonsoft.Json;

namespace WebApi.Models
{
    public class MultipleChoiceQuestions
    {
        [JsonProperty("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [JsonProperty("Choice")]
        public List<string>? Choice { get; set; }
        [JsonProperty("isOtherEnabled")]
        public bool IsOtherEnabled { get; set; }
        [JsonProperty("MaxChoice")]
        public int MaxChoice { get; set; }
        [JsonProperty("isMultiChoice")]
        public bool IsMultiChoice { get; set; }
    }
}
