using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamsClone.Users.Interfaces;
using TeamsClone.Users.Models;

namespace TeamsClone.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [Produces("application/json")]
        [Route("/users")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _userService.GetUsers();
            return Ok(res);
        }

        [Produces("application/json")]
        [Route("/users/{userId}")]
        [HttpGet]
        public async Task<IActionResult> GetById(string userId)
        {
            var res = await _userService.GetById(userId.Trim());
            if (res == null)
            {
                return NotFound($"No user exists with id: {userId}");
            }
            return Ok(res);
        }

        [Produces("application/json")]
        [Route("/users/email/{email}")]
        [HttpGet]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var res = await _userService.GetByEmail(email.Trim());
            if (res == null)
            {
                return NotFound($"No user exists with email: {email}");
            }
            return Ok(res);
        }
    }
}
