using BidOne.API.Models;

namespace BidOne.API.Services
{
    public interface IPersonService
    {
        Task SubmitPerson(Person person);
    }
}
