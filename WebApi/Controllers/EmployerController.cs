using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Models.Dto;
using WebApi.Service;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly IDbService _dbService;
        public EmployerController(IDbService dbService)
        {

            _dbService = dbService;
        }

        [HttpGet("GetApplications")]
        public async Task<IEnumerable<StudentApplication>> GetApplications()
        {
            return await _dbService.GetMultipleAsync();
        }
        [HttpGet("GetAllDefaultQuestions")]
        public async Task<List<DefaultQuestion>> GetDefaultQuestions()
        {
            return await _dbService.GetAllDefaultQuestions();
        }

        // GET api/<EmployerController>/5
        [HttpGet("GetAllQuestions")]
        public async Task<IEnumerable<NewProgram>> GetAllQuestions()
        {
            return await _dbService.GetAllQuestionsAsync();
        }

        // POST api/<EmployerController>
        [HttpPost("AddNewProgram")]
        public void AddNewProgram(NewProgramDTO model)
        {
            _dbService.AddNewProgramQuestionsAsync(model);
        }

        // PUT api/<EmployerController>/5
        [HttpPut("UpdateProgramQuestions{id}")]
        public void UpdateProgramQuestions(string id, NewProgram value)
        {
            _dbService.UpdateProgramQuestionsAsync(id, value);
        }
    }
}
