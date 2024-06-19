using AutoMapper;
using WebApi.Models;
using WebApi.Models.Dto;

namespace WebApi.Helper
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<StudentApplicationDTO, StudentApplication>();
            CreateMap<MultipleChoiceQuestionDTO, MultipleChoiceQuestions>();
            CreateMap<MultipleChoiceQuestions, MultipleChoiceQuestionDTO>();
            CreateMap<CustomQuestionsDTO, CustomQuestions>();
            CreateMap<CustomQuestions, CustomQuestionsDTO>();
            CreateMap<NewProgramDTO, NewProgram>();
            CreateMap<NewProgram, NewProgramDTO>();


        }
    }
}
