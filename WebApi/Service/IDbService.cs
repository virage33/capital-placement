using WebApi.Models;
using WebApi.Models.Dto;

namespace WebApi.Service
{
    public interface IDbService
    {
        Task<IEnumerable<StudentApplication>> GetMultipleAsync();
        Task<IEnumerable<NewProgram>> GetAllQuestionsAsync();
        Task<NewProgram> GetQuestionAsync(string id);
        Task<NewProgramDTO> GetQuestionForStudent(string id);
        Task AddStudentApplicationAsync(StudentApplicationDTO item);
        Task AddNewProgramQuestionsAsync(NewProgramDTO item);
        Task UpdateProgramQuestionsAsync(string id, NewProgram item);
        Task<List<DefaultQuestion>> GetAllDefaultQuestions();
    }
}
