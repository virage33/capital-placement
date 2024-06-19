using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Dto
{
    public class StudentApplicationDTO
    {
        [Required]
        public string FirstName {  get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? CurrentAddress { get; set; }
        public string? Nationality { get; set; }
        public string? IDNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public List<CustomQuestionAnswer>? CustomQuestionAnswers { get; set; }
    }
}
