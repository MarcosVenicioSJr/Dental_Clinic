using Dental_Clinic.Interfaces.Users;
using Dental_Clinic.Jsons.Request;
using Microsoft.AspNetCore.Mvc;

namespace Dental_Clinic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _services;

        public UsersController(IUserServices services)
        {
            _services = services;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserRequest request)
        {
            TryValidateModel(request);

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            _services.CreateUser(request);
            return Ok("Sucesso");
        }

        [HttpPost]
        [Route("CreateUserList")]
        public IActionResult CreateUserList([FromBody] List<CreateUserRequest> request)
        {
            TryValidateModel(request);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _services.CreateUserByList(request);

            return Ok("Sucesso");
        }
    }
}
