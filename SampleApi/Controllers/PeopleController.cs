using Microsoft.AspNetCore.Mvc;
using SampleApi.Models;
using SampleApi.Models.Requests;
using SampleApi.Models.Results;
using System.ComponentModel.DataAnnotations;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status201Created)]
        public IActionResult Add(
            [FromServices] PeopleRepository people,
            [FromBody, Required] AddPerson request)
        {
            var id = people.Add(request);
            return StatusCode(StatusCodes.Status201Created, id);
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PersonDetails>), StatusCodes.Status200OK)]
        public IActionResult GetAll([FromServices] PeopleRepository people)
            => new OkObjectResult(people.Persons);
    }
}