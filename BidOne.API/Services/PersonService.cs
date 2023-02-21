using BidOne.API.Models;
using BidOne.API.Repositories;
using System.ComponentModel.DataAnnotations;

namespace BidOne.API.Services
{
    public class PersonService : IPersonService
    {
        private readonly IExportRepository _exportRepository;
        public PersonService(IExportRepository exportRepository)
        {
            _exportRepository = exportRepository;
        }

        public async Task SubmitPerson(Person person)
        {
            if(person == null || string.IsNullOrEmpty(person.firstName) || string.IsNullOrEmpty(person.lastName))
            {
                throw new ValidationException("Missing or invalid data! please retry");
            }   
            
            await _exportRepository.SaveAsJson(person);
        }
    }
}
