using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WebApi.Models.Enums;

namespace WebApi.Models.Dto
{
    public class PersonalInformationDTO
    {
        [Required]
        [Description("First Name")]
        public string FirstName { get; set; }
        [Required]
        [Description("Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public List<DefaultQuestion> DefaultQuestions { get; set; }
        

    }
}
