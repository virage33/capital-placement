using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Dto;
using WebApi.Service;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly IDbService _dbService;
        public ApplicantController(IDbService dbService)
        {
            _dbService = dbService;
        }

        // GET api/<StudentController>/5
        [HttpGet("GetProgramQuestions{id}")]
        public async Task<NewProgramDTO> GetProgramQuestions(string id)
        {
            var resp = await _dbService.GetQuestionForStudent(id);
            return resp;
        }

        // POST api/<StudentController>
        [HttpPost("SubmitApplication")]
        public async Task Post([FromBody] StudentApplicationDTO value)
        {
            var res = _dbService.AddStudentApplicationAsync(value);
        }

    }
}
