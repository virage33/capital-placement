using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WebApi.Models.Dto;

namespace WebApi.Models
{
    public class NewProgram
    {
        [JsonProperty("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [JsonProperty("Title")]
        public string Title { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("PersonalInfo")]
        public List<DefaultQuestion> PersonalInfo { get; set; }
        [JsonProperty("CustomQuestions")]
        public List<CustomQuestions>? CustomQuestions { get; set; }
    }
}
