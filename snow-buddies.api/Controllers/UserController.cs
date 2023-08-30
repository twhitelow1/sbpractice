using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using snow_buddies.application.IServices;
using snow_buddies.domain.Entities;

namespace snow_buddies.api.Controllers
{
 [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController( IUserService userService )
        {
            _userService = userService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<User>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ActionResult<List<User>> GetAllUsers()
        {
           return Ok(_userService.GetAllUsers());
        }

        [HttpPost]
        [ProducesResponseType(typeof(User), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ActionResult<User> CreateUser(User user )
        {
            return CreatedAtAction("CreateUser", _userService.CreateUser(user));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ActionResult<User> GetUserById(int id)
        {
            return Ok(_userService.GetUserById(id));
        }

    }
}