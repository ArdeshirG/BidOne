using BidOne.API.Models;
using BidOne.API.Services;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;

namespace BidOne.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly IPersonService _personService;

        private readonly ILogger<PersonController> _logger;

        public PersonController(IPersonService personService, ILogger<PersonController> logger)
        {
            _personService = personService;
            _logger = logger;
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, typeof(OkResult))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(void), Description = "Person sumbit failed!")]
        public async Task<IActionResult> SubmitPerson([FromBody] Person personRequest)
        {
            _logger.LogInformation("Received data to submit");

            await _personService.SubmitPerson(personRequest);
            return Ok();
        }
    }
}