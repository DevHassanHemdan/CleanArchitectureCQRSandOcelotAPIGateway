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
        [HttpPost]
        public async Task<ActionResult<UserDTO>> Login(LoginQuery login)
        {
            return await Mediator.Send(login);
        }
    }
}
