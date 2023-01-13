using Application.CQRS.Commands;
using Application.CQRS.Queries;
using Application.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginQuery login)
        {
            return await Mediator.Send(login);
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterCommand command)
        {
            return await Mediator.Send(command);
        }

        //[HttpGet("CurrentUser")]
        //public string CurrentUser()
        //{
        //    var username = HttpContext.User.FindFirst("userName")?.Value;
        //    return "";
        //}
    }
}
