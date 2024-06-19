using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WebApi.Models
{
    public class StudentApplication
    {
        [JsonProperty(propertyName:"id")]
       public string Id { get; set; } = Guid.NewGuid().ToString();
        [JsonProperty(propertyName: "FirstName")]
        public string FirstName { get; set; }
        [JsonProperty(propertyName: "LastName")]
        public string LastName { get; set; }
        [JsonProperty(propertyName: "Email")]
        public string Email { get; set; }
        [JsonProperty(propertyName: "Phone")]
        public string? Phone { get; set; }
        [JsonProperty(propertyName: "CurrentAddress")]
        public string? CurrentAddress { get; set; }
        [JsonProperty(propertyName: "Nationality")]
        public string? Nationality { get; set; }
        [JsonProperty(propertyName: "IDNumber")]
        public string? IDNumber { get; set; }
        [JsonProperty(propertyName: "DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }
        [JsonProperty(propertyName: "Gender")]
        public string? Gender { get; set; }
        [JsonProperty(propertyName: "CustomQuestions")]
        public List<CustomQuestionAnswer>? CustomQuestionAnswers { get; set; }
    }
}
