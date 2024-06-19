using System.ComponentModel.DataAnnotations;
using WebApi.Models.Enums;

namespace WebApi.Models.Dto
{
    public class CustomQuestionsDTO
    {
        [Required]
        public QuestionType QuestionType { get; set; }
        [Required]
        public string Question { get; set; }

        public MultipleChoiceQuestionDTO? DropdownChoice { get; set; }

       
    }
}
