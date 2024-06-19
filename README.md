1. the progra allows you to add default questions and decide which is required for the applicant to fill or not. Also to add custom questions with different question types represented by an enum that enables the fronted 
decide the input type for each question.

 public enum QuestionType
 {
     [Description("Paragraph")]
     Paragraph = 0,
     [Description("Yes/No")]
     YesOrNo = 1,
     [Description("Dropdown")]
     Dropdown = 2,
     [Description("Multiple Choice")]
     MultipleChoice = 3,
     [Description("Date")]
     Date = 4,
     [Description("Number")]
     Number = 5
     
 }
