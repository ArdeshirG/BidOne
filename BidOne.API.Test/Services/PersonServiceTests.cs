using BidOne.API.Models;
using BidOne.API.Services;
using BidOne.API.Test.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidOne.API.Test.Services
{
    public class PersonServiceTests
    {
        [Test]
        public async Task SubmitPersonTest_WithData()
        {
            var exportRepoMock = new ExportRepositoryMock();

            var personService = new PersonService(exportRepoMock.mockRepo.Object);

            var testPerson = new Person
            {
                firstName = "John",
                lastName = "Smith"
            };

            await personService.SubmitPerson(testPerson);

            exportRepoMock.mockRepo.Verify(a => a.SaveAsJson(It.Is<Person>(s => ReferenceEquals(testPerson, s))),
                Times.Once);
        }

        [Test]
        public async Task SubmitPersonTest_WithoutData()
        {
            var exportRepoMock = new ExportRepositoryMock();

            var personService = new PersonService(exportRepoMock.mockRepo.Object);

            var testPerson = new Person
            {
                firstName = "",
                lastName = ""
            };

            try
            {
                await personService.SubmitPerson(testPerson);
            }
            catch (ValidationException ex)
            {
                Assert.Contains("Missing or invalid data! please retry", new List<string> { ex.Message });
                return;
            }
        }
    }
}
