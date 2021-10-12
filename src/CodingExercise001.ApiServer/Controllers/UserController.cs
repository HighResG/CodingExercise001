using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingExercise001.ApiServer.Models.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CodingExercise001.ApiServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserCreationRequestModel model)
        {
            //TODO: Create User - If successful, return a 201 status with the user id as payload, if validation failure, return 400.
            return StatusCode(201, Guid.NewGuid()); //Placeholder until implemented
        }

        [HttpGet]
        public IActionResult Get()
        {
            //TODO: Should return a list of users
            return Ok(new List<UserListItemViewModel>()); //Placeholder until implemented
        }

    }
}
