using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Dto
{
    public class NewProgramDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public List<DefaultQuestion> PersonalInfo { get; set; }
        public List<CustomQuestionsDTO>? CustomQuestions { get; set; }
       
    }
}
