using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Cosmos;
using WebApi.Models;
using WebApi.Models.Dto;
using WebApi.Models.Enums;

namespace WebApi.Service
{
    public class DbService : IDbService
    {
        public List<StudentApplicationDTO> StudentApplications = new List<StudentApplicationDTO>();
        private Container _container;
        private Container _questionsContainer;
        private IMapper _mapper;

        public DbService(
       CosmosClient cosmosDbClient,
       string databaseName,
       string containerName, IMapper mapper)
        {
            _container = cosmosDbClient.GetContainer(databaseName, containerName);
            _questionsContainer = cosmosDbClient.GetContainer(databaseName, "Questions");
            _mapper = mapper;
        }

        public async Task AddNewProgramQuestionsAsync(NewProgramDTO item)
        {
            try
            {
                var questions = _mapper.Map<NewProgram>(item);
                var resp = await _questionsContainer.CreateItemAsync(questions, new PartitionKey(questions.Id));
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task AddStudentApplicationAsync(StudentApplicationDTO item)
        {
            try
            {
                var application = _mapper.Map<StudentApplication>(item);
                await _container.CreateItemAsync(application, new PartitionKey(application.Id));
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task DeleteAsync(string id)
        {
            await _questionsContainer.DeleteItemAsync<NewProgram>(id, new PartitionKey(id));
        }

        public async Task<List<DefaultQuestion>> GetAllDefaultQuestions()
        {
            return  new List<DefaultQuestion>() {
                new DefaultQuestion{ Title="FirstName", IsHidden = false, IsMandatory= true, IsInternal = false, QuestionType = QuestionType.Paragraph},
                new DefaultQuestion{ Title="LastName", IsHidden = false, IsMandatory= true, IsInternal = false, QuestionType = QuestionType.Paragraph},
                new DefaultQuestion{ Title="EmailName", IsHidden = false, IsMandatory= true, IsInternal = false, QuestionType = QuestionType.Paragraph},
                new DefaultQuestion{ Title="Phone", IsHidden = false, IsMandatory= false, IsInternal = false, QuestionType = QuestionType.Paragraph},
                new DefaultQuestion{ Title="CurrentAddress", IsHidden = false, IsMandatory= false, IsInternal = false, QuestionType = QuestionType.Paragraph},
                new DefaultQuestion{ Title="Nationality", IsHidden = false, IsMandatory= false, IsInternal = false, QuestionType = QuestionType.Paragraph},
                new DefaultQuestion{ Title="DateOfBirth", IsHidden = false, IsMandatory= false, IsInternal = false, QuestionType = QuestionType.Date},
                new DefaultQuestion{ Title="Gender", IsHidden = false, IsMandatory= false, IsInternal = false, QuestionType = QuestionType.Paragraph}
            };
        }

        public async Task<IEnumerable<StudentApplication>> GetMultipleAsync()
        {
            try
            {
                var query = _container.GetItemQueryIterator<StudentApplication>(new QueryDefinition("Select * from c"));
                var results = new List<StudentApplication>();
                while (query.HasMoreResults)
                {
                    var response = await query.ReadNextAsync();
                    results.AddRange(response.ToList());
                }
                return results;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task<IEnumerable<NewProgram>> GetAllQuestionsAsync()
        {
            try
            {
                var query = _questionsContainer.GetItemQueryIterator<NewProgram>(new QueryDefinition("select * from c"));
                var results = new List<NewProgram>();
                while (query.HasMoreResults)
                {
                    var response = await query.ReadNextAsync();
                    results.AddRange(response.ToList());
                }
                return results;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public async Task<NewProgram> GetQuestionAsync(string id)
        {
            try
            {
                var response = await _questionsContainer.ReadItemAsync<NewProgram>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<NewProgramDTO> GetQuestionForStudent(string id)
        {
            var resp = await GetQuestionAsync(id);
            return _mapper.Map<NewProgramDTO>(resp);
        }
    
        public async Task UpdateProgramQuestionsAsync(string id, NewProgram item)
        {
            try
            {
                await _questionsContainer.UpsertItemAsync(item, new PartitionKey(id));
            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}
