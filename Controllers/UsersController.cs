using Dental_Clinic.Interfaces.Users;
using Dental_Clinic.Jsons.Request;
using Dental_Clinic.Models;
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

        [HttpGet]
        public IActionResult GetAll()
        {
           List<Users> users = _services.GetAll();
           return Ok(users);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            Users user = _services.GetById(id);
            return Ok(user);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromBody] Users user, int id)
        {
            user.Id = id;
            _services.Update(user);

            return Ok(user);
        }
    }
}
